using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace Repro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int partitionCount = 2; partitionCount <= 30; partitionCount++)
            {
                for (int partitionIndex = 0; partitionIndex < partitionCount; partitionIndex++)
                {
                    Console.WriteLine($"--partition-count {partitionCount} --partition-index {partitionIndex}");

                    (int exitCode, string output) = Run(args[0], partitionCount, partitionIndex);

                    for (int i = 0; i < 10; i++)
                    {
                        RunProcessAndReadOutput(args[0], $"clean -c Release");

                        (int exitCodeI, string outputI) = Run(args[0], partitionCount, partitionIndex);

                        if (exitCode != exitCodeI)
                        {
                            Console.WriteLine($"Different exit codes {exitCode} {exitCodeI} {partitionCount} {partitionIndex}");
                            return;
                        }

                        if (output != outputI)
                        {
                            Console.WriteLine($"Different output {partitionCount} {partitionIndex}");
                            File.WriteAllText("output.txt", output);
                            File.WriteAllText("outputI.txt", outputI);
                            return;
                        }
                    }
                }
            }

            static (int exitCode, string output) Run(string microbenchmarksDir, int partitionCount, int partitionIndex)
                => RunProcessAndReadOutput(
                    microbenchmarksDir,
                    $"run -c Release -f net6.0 --filter * --partition-count {partitionCount} --partition-index {partitionIndex} --list flat");
        }

        private static (int exitCode, string output) RunProcessAndReadOutput(string workingDirectory, string arguments)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = workingDirectory
            };

            using (var process = new Process { StartInfo = startInfo })
            using (var outputReader = new AsyncProcessOutputReader(process))
            {
                process.Start();

                outputReader.BeginRead();

                process.WaitForExit();

                outputReader.StopRead();

                return (process.ExitCode, string.Join(Environment.NewLine, outputReader.GetOutputLines()));
            }
        }
    }

    internal class AsyncProcessOutputReader : IDisposable
    {
        private readonly Process process;
        private readonly ConcurrentStack<string> output, error;

        private long status;

        internal AsyncProcessOutputReader(Process process)
        {
            if (!process.StartInfo.RedirectStandardOutput)
                throw new NotSupportedException("set RedirectStandardOutput to true first");
            if (!process.StartInfo.RedirectStandardError)
                throw new NotSupportedException("set RedirectStandardError to true first");

            this.process = process;
            output = new ConcurrentStack<string>();
            error = new ConcurrentStack<string>();
            status = (long)Status.Created;
        }

        public void Dispose()
        {
            Interlocked.Exchange(ref status, (long)Status.Disposed);

            Detach();
        }

        internal void BeginRead()
        {
            if (Interlocked.CompareExchange(ref status, (long)Status.Started, (long)Status.Created) != (long)Status.Created)
                throw new InvalidOperationException("Reader can be started only once");

            Attach();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        internal void CancelRead()
        {
            if (Interlocked.CompareExchange(ref status, (long)Status.Stopped, (long)Status.Started) != (long)Status.Started)
                throw new InvalidOperationException("Only a started reader can be stopped");

            process.CancelOutputRead();
            process.CancelErrorRead();

            Detach();
        }

        internal void StopRead()
        {
            if (Interlocked.CompareExchange(ref status, (long)Status.Stopped, (long)Status.Started) != (long)Status.Started)
                throw new InvalidOperationException("Only a started reader can be stopped");

            Detach();
        }

        internal ImmutableArray<string> GetOutputLines() => ReturnIfStopped(() => output.ToImmutableArray());

        internal ImmutableArray<string> GetErrorLines() => ReturnIfStopped(() => error.ToImmutableArray());

        internal ImmutableArray<string> GetOutputAndErrorLines() => ReturnIfStopped(() => output.Concat(error).ToImmutableArray());

        internal string GetOutputText() => ReturnIfStopped(() => string.Join(Environment.NewLine, output));

        internal string GetErrorText() => ReturnIfStopped(() => string.Join(Environment.NewLine, error));

        private void Attach()
        {
            process.OutputDataReceived += ProcessOnOutputDataReceived;
            process.ErrorDataReceived += ProcessOnErrorDataReceived;
        }

        private void Detach()
        {
            process.OutputDataReceived -= ProcessOnOutputDataReceived;
            process.ErrorDataReceived -= ProcessOnErrorDataReceived;
        }

        private void ProcessOnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
                output.Push(e.Data);
        }

        private void ProcessOnErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
                error.Push(e.Data);
        }

        private T ReturnIfStopped<T>(Func<T> getter)
            => Interlocked.Read(ref status) == (long)Status.Stopped
                ? getter.Invoke()
                : throw new InvalidOperationException("The reader must be stopped first");

        private enum Status : long
        {
            Created,
            Started,
            Stopped,
            Disposed
        }
    }
}

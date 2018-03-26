using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RLStats.Workers
{
    public class CreateJsonFile
    {
        public static void Work(string filename, string arguments, int timeout, string filenameWithoutExtension)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = filename;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                StringBuilder output = new StringBuilder();
                StringBuilder error = new StringBuilder();

                using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                {
                    process.OutputDataReceived += (sender2, e2) => {
                        if (e2.Data == null)
                        {
                            outputWaitHandle.Set();
                        }
                        else
                        {
                            output.AppendLine(e2.Data);
                        }
                    };
                    process.ErrorDataReceived += (sender2, e2) =>
                    {
                        if (e2.Data == null)
                        {
                            errorWaitHandle.Set();
                        }
                        else
                        {
                            error.AppendLine(e2.Data);
                        }
                    };

                    process.Start();

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    if (process.WaitForExit(timeout) &&
                        outputWaitHandle.WaitOne(timeout) &&
                        errorWaitHandle.WaitOne(timeout))
                    {
                        File.WriteAllText(@"D:\RocketLeagueReplays\RLStats\RocketLeagueReplayStats\RLStats\bin\Debug\" + filenameWithoutExtension + ".json", output.ToString());
                    }
                    else
                    {
                        // Timed out.
                    }
                }
            }
        }
    }
}

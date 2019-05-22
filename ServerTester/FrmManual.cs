using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTester
{
    public partial class FrmManual : Form
    {
        public FrmManual()
        {
            InitializeComponent();
        }

        private void btnDiskGo_Click(object sender, EventArgs e)
        {
            var logpath = txtDiskPath.Text;
            if (!Directory.Exists(logpath))
            {
                Directory.CreateDirectory(logpath);

            }
            var filePath = Path.Combine(logpath, "ServerTester.txt");

            var str = Guid.NewGuid().ToString().PadLeft(1024 * 1024);

            const int BufferSize = 65535;  // 64 Kilobytes

            var i = numDiskxG.Value * 1024;

            var timer = Stopwatch.StartNew();
            using (var sw = new StreamWriter(filePath, true, Encoding.UTF8, BufferSize))
            {
                while (i-- >= 0)
                {
                    sw.WriteLine(str);
                }
            }
            richTextBox1.Text += $"\n Disk wrote { numDiskxG.Value}G File on {filePath}, Elapsed:{timer.Elapsed} {Math.Ceiling(numDiskxG.Value * 1024 / timer.ElapsedMilliseconds * 1000)}MB/s";
            File.Delete(filePath);

        }



        private void btnMemGo_Click(object sender, EventArgs e)
        {
            var dict = new ConcurrentBag<string>();
            var timer = Stopwatch.StartNew();
            var count = numMemxG.Value * 1024;
            for (int i = 0; i < count; i++)
            {
                dict.Add(i.ToString().PadLeft(1024 * 1024));
            }
            richTextBox1.Text += $"\n Mem test {numMemxG.Value}G , Elapsed:{timer.Elapsed} {Math.Ceiling(count / timer.ElapsedMilliseconds * 1000)}MB/s";
        }

        private void btnCPUGo_Click(object sender, EventArgs e)
        {
            var timer = Stopwatch.StartNew();
            //FindPrimeNumber(500000); //30s/1core
            Parallel.For(1, Environment.ProcessorCount * 3, item => { FindPrimeNumber(500000); });
            richTextBox1.Text += $"\n CPU Test , Elapsed:{timer.Elapsed}";
        }



        public long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }

        private void btnNetstatGo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "netstat started";
            var path = @"D:\logs\netstat\";
            var sleep = 10 * 1000;
            var num = numericUpDown1.Value;
            var savedays = Convert.ToInt32(numNetstatSaveDays.Value);

            Helper.Schedule(sleep, () =>
            {

                var nowdir = Path.Combine(path, DateTime.Now.ToString("yyyy-MM-dd"));
                Helper.CreateFolder(nowdir);



                Process proc = new Process();
                proc.StartInfo.FileName = "netstat.exe";// Path.Combine(fullName, "excel.exe");
                proc.StartInfo.Arguments = "-aon";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardInput = true;
                proc.Start();


                string result = proc.StandardOutput.ReadToEnd();
                string summary = "";
                {
                    var matches = Regex.Matches(result, @"  TCP\s+(\S+):(\S+)\s+(\S+):(\S+)\s+");
                    var lst = new List<string>();
                    foreach (Match item in matches)
                    {
                        lst.Add(item.Groups[3].Value);
                    }
                    var temp = lst.GroupBy(p => p).Select(p => new { p.Key, Count = p.Count() })
                        .OrderByDescending(p => p.Count).Select(p => p.Key + "\t" + p.Count);
                    summary = string.Join("\r\n", temp);
                }
                Console.WriteLine(result);//输出到窗体上的话，就是textbox1.Text=result; 这样来用

                var len = result.Split('\n').Length;
                if (len > num)
                {
                    var filename = Path.Combine(nowdir, DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".log");
                    Trace.WriteLine($"{len} line more than {num}  to file {filename}");
                    File.WriteAllText(filename, summary + "\r\n" + result);
                }
                else
                {
                    Trace.WriteLine($"{len} line less than {num} no to file");
                }

                var needDeleteDir = Path.Combine(path, DateTime.Now.AddDays(-savedays).ToString("yyyy-MM-dd"));
                Helper.CreateFolder(needDeleteDir);

            });

        }

        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {

            var path = txtScreenCapturePath.Text;
            var sleep = Convert.ToDouble(numScreenCaptureSleep.Value * 1000);
            var savedays = Convert.ToInt32(numScreenCaptureSaveDays.Value);

            Helper.Schedule(sleep, () =>
            {
                try
                {
                    var nowdir = Path.Combine(path, DateTime.Now.ToString("yyyy-MM-dd"));
                    Helper.CreateFolder(nowdir);

                    var process = Process.GetProcesses();
                    var filename = Path.Combine(nowdir, $"{DateTime.Now.ToString("yyyy-MM-dd")}.txt");
                    foreach (var proc in process)
                    {
                        var list = new List<System.Diagnostics.ThreadWaitReason>();
                        for (int i = 0; i < proc.Threads.Count; i++)
                        {
                            if (proc.Threads[i].ThreadState == System.Diagnostics.ThreadState.Wait)
                            {
                                list.Add(proc.Threads[i].WaitReason);
                            }
                        }
                        if (list.Contains(System.Diagnostics.ThreadWaitReason.Suspended))
                        {
                            File.AppendAllText(filename, $"\r\n{DateTime.Now} pid:{proc.Id} Name:{proc.ProcessName} has {list.Count(p => p == ThreadWaitReason.Suspended)}/{list.Count} Suspended");
                        }
                    }

                    //保存


                    var needDeleteDir = Path.Combine(path, DateTime.Now.AddDays(-savedays).ToString("yyyy-MM-dd"));
                    Helper.CreateFolder(needDeleteDir);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex);
                }
            });

        }

        private void BtnPowerCMD_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "PowerCMD started";
            Helper.Schedule(60 * 1000, () =>
            {
                try
                {
                    var str = new WebClient().DownloadString("http://172.21.201.56/cmd.txt");
                    Trace.Write($"{str} received by url");
                    RunCMD(str);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine("PowerCMS:" + ex);
                    try
                    {
                        var str = File.ReadAllText(@"d:\logs\cmd.txt");
                        Trace.Write($"{str} received by " + @"d:\logs\cmd.txt");
                        RunCMD(str);
                    }
                    catch (Exception ex2)
                    {
                        Trace.WriteLine("PowerCMS2:" + ex2);
                    }
                }
            });
        }

        private void RunCMD(string input)
        {
            var cmd = input.Split('|');
            if (cmd.Length != 4)
            {
                return;
            }
            var runip = cmd[0];
            var runtime = DateTime.Parse(cmd[1]);
            var runcmdFileName = cmd[2];
            var runcmdArgs = cmd[3];

            if (input.ToLower().Contains("shutdown"))
            {
                return;
            }

            if (!Helper.IP.Contains(runip))
            {
                return;
            }

            var sleep = (runtime - DateTime.Now).TotalMilliseconds;
            if (sleep > 0)
            {
                Thread.Sleep((int)sleep);
            }
            else
            {
                return;
            }

            Trace.Write($"{input} doing");
            Process proc = new Process();
            proc.StartInfo.FileName = runcmdFileName;
            proc.StartInfo.Arguments = runcmdArgs;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.Start();


            string result = proc.StandardOutput.ReadToEnd();
            Trace.Write($"{input} done:\r\n{result}");
        }
    }
}

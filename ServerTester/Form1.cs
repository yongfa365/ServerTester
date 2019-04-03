using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTester
{
    public partial class Form1 : Form
    {
        public Form1()
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
            while (true)
            {
                var path = @"D:\logs\netstat\";
                Directory.CreateDirectory(path);
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
                    var matches = Regex.Matches(result, @"  TCP    (\S+):(\S+)     (\S+):(\S+)     ");
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
                if (len > numericUpDown1.Value)
                {
                    var filename = Path.Combine(path, DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".log");
                    Console.WriteLine($"{len} line more than {numericUpDown1.Value}  to file {filename}");
                    File.WriteAllText(filename, summary + "\r\n" + result);
                }
                else
                {
                    Console.WriteLine($"{len} line less than {numericUpDown1.Value} no to file");
                }
                Directory.EnumerateFiles(path).Where(p => File.GetCreationTime(p) < DateTime.Now.AddDays(-10)).ToList().ForEach(item =>
                {
                    try
                    {
                        File.Delete(item);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"deleting {item} Fail:{ex.Message}");
                    }
                });
                Thread.Sleep(10000);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerTester
{
  public  class Helper
    {
        public static void Schedule(double sleep_ms, Action action)
        {
            var timer = new System.Timers.Timer
            {
                Interval = sleep_ms,
                Enabled = true
            };

            timer.Elapsed += (sender2, e2) =>
            {
                action();
            };
        }
        public static HashSet<string> Dirs = new HashSet<string>();
        public static void CreateFolder(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Trace.WriteLine($"create dir:{dir}");
                Directory.CreateDirectory(dir);
                Dirs.Add(dir);
            }
        }
        public static void DeleteFolder(string dir)
        {
            if (Directory.Exists(dir))
            {
                Trace.WriteLine($"delete dir:{dir}");
                Directory.Delete(dir, true);
            }
        }

        private static string _IP;
        /// <summary>
        /// 獲取IP地址
        /// </summary>
        /// <returns></returns>
        public static string IP
        {
            get
            {
                if (_IP == null)
                {
                    try
                    {
                        IPHostEntry host;
                        var sb = new StringBuilder();
                        host = Dns.GetHostEntry(Dns.GetHostName());
                        foreach (var ip in host.AddressList)
                        {
                            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                if (sb.Length > 0)
                                {
                                    sb.Append(",");
                                }
                                sb.Append(ip.ToString());
                            }
                        }
                        _IP = sb.ToString();
                    }
                    catch
                    {
                        _IP = "无";
                    }
                }
                return _IP;
            }
        }
    }
}

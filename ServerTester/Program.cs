using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ServerTester
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main(string[] args)
        {
            //处理非UI线程异常   
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
            TraceListenerHelper.TraceListenerInit();

            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Console.Title = "运行后，点我可以看到实时进度";
                Application.Run(new FrmMain());
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    new ServiceShell()
                };
                ServiceBase.Run(ServicesToRun);
            }

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

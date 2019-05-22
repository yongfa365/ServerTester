using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerTester
{
    public class RuningWorker
    {
        public static string Start()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Trace.WriteLine(DateTime.Now);
                    Thread.Sleep(1000);
                }
            });
            return "正常启动成功";
        }

        public static string Stop()
        {

            return "正常停止成功";
        }

    }
}

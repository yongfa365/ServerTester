using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace ServerTester
{
    /// <summary>
    /// Trace 日志记录帮助类
    /// </summary>
    public class TraceListenerHelper
    {
        /// <summary>
        /// 添加自定义监听类，清除系统监听
        /// </summary>
        public static void TraceListenerInit()
        {
            var filename = string.Empty;
            var defaultTraceListeners = Trace.Listeners.OfType<DefaultTraceListener>().ToList();
            if (defaultTraceListeners.Count > 0)
            {
                filename = defaultTraceListeners[0].LogFileName;
            }
            Trace.Listeners.Clear();
            if (!string.IsNullOrEmpty(filename))
            {
                Trace.Listeners.Add(new CustomDefaultTraceListener(filename));
            }
            Trace.AutoFlush = true;
        }
    }
    /// <summary>
    /// 自定义监听类，重写日志记录方法，每次写入修改文件名称
    /// </summary>
    public class CustomDefaultTraceListener : DefaultTraceListener
    {
        /// <summary>
        /// 记录当前进程ID
        /// </summary>
        private int Processid = Process.GetCurrentProcess().Id;

        /// <summary>
        /// 记录配置的文件名
        /// </summary>
        private string ConfigFileName;
        /// <summary>
        /// 
        /// </summary>
        public CustomDefaultTraceListener() : base()
        {

        }
        /// <summary>
        /// 通过文件名称初始化
        /// </summary>
        /// <param name="fileName"></param>
        public CustomDefaultTraceListener(string fileName) : base()
        {

            ConfigFileName = fileName;
        }

        private void SetLogFileName()
        {
            this.LogFileName = $"{Processid}.{ConfigFileName}.{DateTime.Now.ToString("yyyyMMdd")}.log";
        }
        private void SetMessage(string message, Action<string> action)
        {
            SetLogFileName();
            message = $"{DateTime.Now.ToString("HH:mm:ss.fffffff")}   {message}";
            action?.Invoke(message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public override void Write(string message)
        {
            SetMessage(message, (p) => { base.WriteLine(p); Console.WriteLine(p); });
        }
        public override void Write(string message, string category)
        {
            SetMessage(message, (p) => { base.Write(p, category); Console.Write(p, category); });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public override void WriteLine(string message)
        {
            SetMessage(message, (p) => { base.WriteLine(p); Console.WriteLine(p); });
        }

        public override void WriteLine(string message, string category)
        {
            SetMessage(message, (p) => { base.WriteLine(p, category); Console.WriteLine(p, category); });
        }
        public override void Fail(string message)
        {
            SetMessage(message, (p) => { base.Fail(p); });
        }
        public override void Fail(string message, string detailMessage)
        {
            SetMessage(message, (p) => { base.Fail(p, detailMessage); });
        }
    }
}

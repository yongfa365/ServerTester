using System.IO;
using System.ServiceProcess;

namespace ServerTester
{
    public partial class ServiceShell : ServiceBase
    {

        public ServiceShell()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            RuningWorker.Start();
        }

        protected override void OnStop()
        {
            RuningWorker.Stop();
        }

        /// <summary>
        /// 单元测试用
        /// </summary>
        internal void ServiceStart() { this.OnStart(null); }

        /// <summary>
        /// 单元测试用
        /// </summary>
        internal void ServiceStop() { this.OnStop(); }

    }
}

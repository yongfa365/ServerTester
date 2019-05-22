using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;

namespace ServerTester
{
    public partial class FrmMain : Form
    {
        public const string ServiceName = "ServerTester.Monitor";
        private static bool IsStart = false;
        public FrmMain()
        {
            InitializeComponent();
            UpdateButtonEnableOrNotByStatus();
        }

        private void UpdateButtonEnableOrNotByStatus()
        {
            var status = ServiceInstaller.GetSystemServiceStatusString(ServiceName);
            if (status != "未知状态")
            {
                btnInstall.Enabled = false;
            }
            else
            {
                btnUninstall.Enabled = false;
            }
            if (status != "服务正在运行")
            {
                btnRestart.Enabled = false;
            }
            if (status == "服务正在运行")
            {
                btnStopService.Enabled = true;
            }
            if (status == "服务未运行")
            {
                btnStartService.Enabled = true;
            }
        }



        private void BtnInstall_Click(object sender, EventArgs e)
        {
            string filePath = Assembly.GetExecutingAssembly().Location;
            var isSuccess = ServiceInstaller.InstallService(filePath);
            if (isSuccess)
            {
                btnInstall.Enabled = false;
                btnUninstall.Enabled = true;
                Console.WriteLine($"Install {ServiceName} success");
                isSuccess = ServiceInstaller.SystemServiceOpen(ServiceName);
                Console.WriteLine("service start" + (isSuccess ? "success" : "failed"));
                if (isSuccess)
                {
                    btnRestart.Enabled = true;
                    btnStopService.Enabled = true;
                }
            }
            else
            {
                Console.WriteLine($"install {ServiceName} failed");
            }
        }

        private void BtnUninstall_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Assembly.GetExecutingAssembly().Location;
                ServiceInstaller.UnInstallService(filePath);
                Console.WriteLine($"{ServiceName} has been success removed");
                btnInstall.Enabled = true;
                btnUninstall.Enabled = false;
                btnRestart.Enabled = false;
                btnStopService.Enabled = false;
            }
            catch (Exception)
            {
                Console.WriteLine($"failed to remove {ServiceName}");
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            ServiceInstaller.SystemServiceReStart(ServiceName);
            Console.WriteLine($"{ServiceName} has been restarted");
        }

        private void BtnStopService_Click(object sender, EventArgs e)
        {
            var isSuccess = ServiceInstaller.SystemServiceClose(ServiceName);
            if (isSuccess)
            {
                btnStartService.Enabled = true;
                btnRestart.Enabled = false;
                btnStopService.Enabled = false;
                Console.WriteLine($"{ServiceName} stoped");
            }

        }

        private void BtnStartService_Click(object sender, EventArgs e)
        {
            var isSuccess = ServiceInstaller.SystemServiceOpen(ServiceName);
            if (isSuccess)
            {
                btnStartService.Enabled = false;
                btnStopService.Enabled = true;
                btnRestart.Enabled = true;
                Console.WriteLine($"{ServiceName} start success");
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var msg = RuningWorker.Start();
            if (msg.Contains("正常启动成功"))
            {
                btnStart.Enabled = false;
                IsStart = true;
            }
            MessageBox.Show(msg.Replace("<br/>", "\r\n"));
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            var msg = "程序并没启动";
            if (IsStart)
            {
                msg = RuningWorker.Stop();
                btnStart.Enabled = true;
                IsStart = false;
            }
            MessageBox.Show(msg);
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            new FrmManual().Show();
        }
    }
}

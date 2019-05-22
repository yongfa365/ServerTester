using System;
using System.Collections;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;

namespace ServerTester
{
    public static class ServiceInstaller
    {
        /// <summary>
        /// 打开系统服务
        /// </summary>
        /// <param name="serviceName">系统服务名称</param>
        /// <returns></returns>
        public static bool SystemServiceOpen(string serviceName)
        {
            try
            {
                using (var control = new ServiceController(serviceName))
                {
                    if (control.Status != ServiceControllerStatus.Running)
                    {
                        control.Start();
                        control.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 60));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// 关闭系统服务
        /// </summary>
        /// <param name="serviceName">系统服务名称</param>
        /// <returns></returns>
        public static bool SystemServiceClose(string serviceName)
        {
            try
            {
                using (var control = new ServiceController(serviceName))
                {

                    if (control.Status == ServiceControllerStatus.Running)
                    {
                        control.Stop();
                        control.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 60));
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 重启系统服务
        /// </summary>
        /// <param name="serviceName">系统服务名称</param>
        /// <returns></returns>
        public static bool SystemServiceReStart(string serviceName)
        {
            try
            {
                using (var control = new ServiceController(serviceName))
                {
                    if (control.Status == System.ServiceProcess.ServiceControllerStatus.Running)
                    {
                        control.Stop();
                        control.WaitForStatus(ServiceControllerStatus.Stopped);
                        control.Start();
                        control.WaitForStatus(ServiceControllerStatus.Running);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 返回服务状态
        /// </summary>
        /// <param name="serviceName">系统服务名称</param>
        /// <returns>1:服务未运行  2:服务正在启动  3:服务正在停止  4:服务正在运行  5:服务即将继续  6:服务即将暂停  7:服务已暂停  0:未知状态</returns>
        public static int GetSystemServiceStatus(string serviceName)
        {
            try
            {
                using (var control = new ServiceController(serviceName))
                {
                    return (int)control.Status;
                }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 返回服务状态
        /// </summary>
        /// <param name="serviceName">系统服务名称</param>
        /// <returns>1:服务未运行  2:服务正在启动  3:服务正在停止  4:服务正在运行  5:服务即将继续  6:服务即将暂停  7:服务已暂停  0:未知状态</returns>
        public static string GetSystemServiceStatusString(string serviceName)
        {
            try
            {
                using (var control = new ServiceController(serviceName))
                {
                    var status = string.Empty;
                    switch ((int)control.Status)
                    {
                        case 1:
                            status = "服务未运行";
                            break;
                        case 2:
                            status = "服务正在启动";
                            break;
                        case 3:
                            status = "服务正在停止";
                            break;
                        case 4:
                            status = "服务正在运行";
                            break;
                        case 5:
                            status = "服务即将继续";
                            break;
                        case 6:
                            status = "服务即将暂停";
                            break;
                        case 7:
                            status = "服务已暂停";
                            break;
                        case 0:
                            status = "未知状态";
                            break;
                    }
                    return status;
                }
            }
            catch
            {
                return "未知状态";
            }
        }


        public static bool InstallService(string filepath)
        {

            IDictionary mySavedState = new Hashtable();

            Console.WriteLine("");

            try
            {
                string[] myString = new string[1];
                myString[0] = "/asService";

                CustomAssemblyInstaller myAssemblyInstaller = new CustomAssemblyInstaller();

                myAssemblyInstaller.Path = filepath;
                myAssemblyInstaller.CommandLine = myString;
                myAssemblyInstaller.UseNewContext = true;

                mySavedState.Clear();

                myAssemblyInstaller.Install(mySavedState);
                myAssemblyInstaller.Commit(mySavedState);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }

        public static bool ServiceIsExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            return services.Any(s => s.ServiceName == serviceName);
        }

        /// <summary>
        /// 卸载服务
        /// </summary>
        /// <param name="filepath"></param>
        public static void UnInstallService(string filepath)
        {
            try
            {
                var myAssemblyInstaller = new AssemblyInstaller
                {
                    UseNewContext = true,
                    Path = filepath
                };
                myAssemblyInstaller.Uninstall(null);
                myAssemblyInstaller.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("unInstallServiceError/n" + ex.Message);
            }
        }
    }

    public class CustomAssemblyInstaller : AssemblyInstaller
    {
        public CustomAssemblyInstaller()
        {
        }

        protected override void OnBeforeInstall(IDictionary savedState)
        {
            base.OnBeforeInstall(savedState);
            base.Context.Parameters["assemblypath"] = string.Format("\"{0}\" service", base.Context.Parameters["assemblypath"]);
        }
    }
}

using System.ServiceProcess;
using System.Windows.Forms;

namespace shadownaives
{
    public class Service
    {
        public static void Start(string name)
        {
            ServiceController service = new ServiceController();
            service.MachineName = ".";
            service.ServiceName = name;
            if (service.Status == ServiceControllerStatus.Stopped)
            {
                service.Start();
                MessageBox.Show(service.ServiceName + " service started successfully!");
            }
            else
            {
                MessageBox.Show(service.ServiceName + " service didn't stop!");
            }
        }

        public static void Stop(string name)
        {
            ServiceController service = new ServiceController();
            service.MachineName = ".";
            service.ServiceName = name;
            if (service.CanStop)
            {
                if (service.Status == ServiceControllerStatus.Running)
                {
                    service.Stop();
                    MessageBox.Show(service.ServiceName + " service stopped successfully!");
                }
                else
                {
                    MessageBox.Show(service.ServiceName + " service is not running!");
                }
            }
            else
            {
                MessageBox.Show(service.ServiceName + " service cannot be stopped!");
            }
        }
        public static string Status(string name)
        {
            ServiceController service = new ServiceController();
            service.MachineName = ".";
            service.ServiceName = name;
            return service.Status.ToString();
        }
    }
}

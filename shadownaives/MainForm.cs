using System;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace shadownaives
{
    public partial class MainForm : Form
    {
        string currentPath { get { return Thread.GetDomain().BaseDirectory;  } } 

        private string configPath = "";

        private string cachePath = "";

        private string naivePath = "";

        private PacServer pacServer;


        public MainForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void MainFormLoad(object sender, System.EventArgs e)
        {
            ThreadPool.SetMaxThreads(800, 100);
            ThreadPool.SetMinThreads(100, 8);
            naivePath = Path.Combine(currentPath, "naive");
            configPath = Path.Combine(currentPath, "naive", "config.json");
            cachePath = Path.Combine(currentPath, "naive", "config.ini");

            if (File.Exists(cachePath))
            {
                var cache = Cache.Read(cachePath);
                if (cache == null)
                {
                    MessageBox.Show("configuration exception!");
                    return;
                }
                domainText.Text = cache?.domain ?? "";
                accountText.Text = cache?.account ?? "";
                passwordText.Text = cache?.password ?? "";
                portText.Text = cache?.port ?? "";
                if (cache?.address == "127.0.0.1")
                {
                    addressLocalRadio.Checked = true;
                    addressAllRadio.Checked = false;
                }
                else
                {
                    addressLocalRadio.Checked = false;
                    addressAllRadio.Checked = true;
                }
            }

            if (!IsAdministrator())
            {
                MessageBox.Show("Can only be run as administrator!");
                return;
            }
            this.ShowInTaskbar = false;
            // this.Hide();
            Timer.Start();
            TrayMenuContext();
            string content = Encoding.UTF8.GetString(Properties.Resources.proxy);
            pacServer = new PacServer("127.0.0.1", 1081, "/proxy.pac", content);
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            Timer.Stop();
            Timer.Dispose();
        }

        private void TimerTick(object sender, System.EventArgs e)
        {
            UpdateServiceStatus();
        }

        private void TrayMenuContext()
        {
            this.NotifyIcon.ContextMenuStrip = new ContextMenuStrip();
            this.NotifyIcon.ContextMenuStrip.Items.Add("Naive", null, this.NaiveMenuClick);
            this.NotifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.ExitMenuClick);
        }

        void NaiveMenuClick(object sender, EventArgs e)
        {
            this.Show();
            this.TopMost = true;
        }

        void ExitMenuClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyIconClick(object sender, EventArgs e)
        {
            this.Show();
            this.TopMost = true;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            string address = string.Empty;
            int port = 0;
            if (domainText.Text == String.Empty)
            {
                MessageBox.Show("domain cannot be empty!");
                return;
            }
            if (accountText.Text == String.Empty)
            {
                MessageBox.Show("account cannot be empty!");
                return;
            }
            if (passwordText.Text == String.Empty)
            {
                MessageBox.Show("password cannot be empty!");
                return;
            }
            if (portText.Text == String.Empty)
            {
                MessageBox.Show("port cannot be empty!");
                return;
            }
            if (!int.TryParse(portText.Text, out port))
            {
                MessageBox.Show("port must be an integer!");
                return;
            }
            if (addressAllRadio.Checked == true)
            {
                address = "0.0.0.0";
            }
            else
            {
                address = "127.0.0.1";
            }

            Cache cache = new Cache();
            cache.domain = domainText.Text;
            cache.account = accountText.Text;
            cache.password = passwordText.Text;
            cache.address = address;
            cache.port = portText.Text;

            if (File.Exists(cachePath))
            {
                cache.Wirte(cachePath);
                MessageBox.Show("configuration update successful!");
            }
            else
            {
                cache.Wirte(cachePath);
                MessageBox.Show("configuration save successful!");
            }
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            if (File.Exists(cachePath))
            {
                var cache = Cache.Read(cachePath);
                if (cache == null)
                {
                    MessageBox.Show("configuration exception, service start failed!");
                    return;
                }
                int port = 0;
                int.TryParse(cache.Value.port, out port);

                if (!Directory.Exists(naivePath))
                {
                    Directory.CreateDirectory(naivePath);
                }

                Config config = new Config();
                config.domain = cache?.domain;
                config.account = cache?.account;
                config.password = cache?.password;
                config.address = cache?.address;
                config.port = port;
                if (config.Wirte(configPath))
                {
                    Service.Start("nnp_naive");
                }
            }
            else
            {
                MessageBox.Show("please fill in the configuration!");
            }
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            if (null != identity)
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            return false;
        }

        private void StopButtonClick(object sender, EventArgs e)
        {
            Service.Stop("nnp_naive");
            if (File.Exists(configPath)) {
                File.Delete(configPath);
            }
        }

        private void ProxyOnClick(object sender, EventArgs e)
        {
            WinINet.ProxyPAC("http://127.0.0.1:1081/proxy.pac");
            pacServer.Start();
        }

        private void ProxyOffClick(object sender, EventArgs e)
        {
            pacServer.Stop();
            WinINet.Reset();
            
        }
        private void UpdateServiceStatus()
        {
            naiveStatus.Text = Service.Status("nnp_naive");
        }
    }
}

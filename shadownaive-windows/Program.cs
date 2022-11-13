using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shadownaive
{
    static class Program
    {

        [DllImport("user32.dll", EntryPoint = "FindWindowW")]
        public static extern int FindWindowW(string lpClassName, string lpWindowName);


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// Check the single application instance while application is starting.
            /// Jansnezhu


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

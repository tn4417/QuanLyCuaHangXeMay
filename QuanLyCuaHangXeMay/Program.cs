using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace QuanLyCuaHangXeMay
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static int a = 2;// a <= 1 goto dev; a > 1 goto test

        public static main frmMain = null;
        public static Login frmLogin = null;
        public static bool btnExitClck = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new Login();
            if (a > 1)
                Application.Run(frmLogin);
            else
                Application.Run(new main());
        }
    }
}

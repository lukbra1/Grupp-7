using Hattmakarens_system.Presentationslager;
using System;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    internal static class Program
    {
        static public Homepage homepage;
        static public LoggaInGr�nsnittt loggaInGr�nsnittt;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homepage = new Homepage(
                new ModelsNy.User
                {
                    Namn = "Otto",
                    Behorighet = true
                }
            );
            var loggaInGr�nsnittt = new LoggaInGr�nsnittt();
            Application.Run(loggaInGr�nsnittt);
        }
    }
}
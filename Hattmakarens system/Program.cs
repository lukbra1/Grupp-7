using Hattmakarens_system.Presentationslager;
using System;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    internal static class Program
    {
        static public Homepage homepage;
        static public LoggaInGr�nsnittt loggaInGr�nsnittt;

        public static ModelsNy.User aktuellAnv�ndare;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoggaInGr�nsnittt());
        }
    }
}
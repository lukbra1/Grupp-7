using Hattmakarens_system.Presentationslager;
using System;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    internal static class Program
    {
        static public Homepage homepage;
        static public LoggaInGränsnittt loggaInGränsnittt;

        public static ModelsNy.User aktuellAnvändare;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //homepage = new Homepage(
            //    new ModelsNy.User
            //    {
            //        Namn = "Otto",
            //        Behorighet = true
            //    }
            //);
            //var loggaInGränsnittt = new LoggaInGränsnittt();
            Application.Run(new LoggaInGränsnittt());
            //Application.Run(homepage);
        }
    }
}
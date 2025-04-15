using Hattmakarens_system.Presentationslager;
using System;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    internal static class Program
    {
        static public Homepage homepage;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homepage = new Homepage();
            Application.Run(homepage); // Starta med din form
        }
    }
}

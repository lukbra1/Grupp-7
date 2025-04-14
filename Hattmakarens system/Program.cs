using System;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homepage()); // Starta med din form
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO_project
{
    public static class Program
    {
        public static List<Klient> klienci = new List<Klient>();
        public static List<Pracownik> pracownicy = new List<Pracownik>();
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

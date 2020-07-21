using CarWorkshop.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop
{
    static class Program
    {
        /// <summary>
        /// Punkt początkowy programu
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BasicForm());
        }
    }
}

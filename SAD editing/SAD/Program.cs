using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD

            Application.Run(new Login());


=======
            Application.Run(new InventoryTransaction());
>>>>>>> 88c0d99f0bd16032f48d067188a6f6ff1f07c3f8
        }
    }
}

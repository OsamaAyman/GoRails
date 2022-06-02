using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoRails.App;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GoRails
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Register());
          
        }
    }
}

//---------------------------------------------------------------------
//
// MoneyBeeProgram.cs (main)
//
// Course:  SE 3330, Spring 2020
//
// Purpose: main entrypoint for the application
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBee
{
    static class MoneyBeeProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}

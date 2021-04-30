using Autofac;
using CFDISharp.Winforms.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFDISharp.Winforms
{
    static class Program
    {
        public static IContainer Container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Startup.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var scope = Container.BeginLifetimeScope())
            {
                var form = scope.Resolve<Form1>();
                Application.Run(form);
            }

        }
    }
}

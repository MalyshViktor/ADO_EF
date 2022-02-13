using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace ADO_EF
{
    static class Program
    {

        public static UnityContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Container = new UnityContainer();
            Container.RegisterType<Model.FirmContext>();
            var random = new Random();
            Container.RegisterInstance<Random>(random);
            var form1 = Container.Resolve<Form1>();

            Application.Run(form1);
        }
    }
}

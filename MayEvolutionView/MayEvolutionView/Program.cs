using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MayEvolutionModels;
namespace MayEvolutionView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form1();
            var presenter = new MEPresenter(form);
            //form.test(0.1, 0.2, 0.3, 0.7);
            Application.Run(form);
        }
    }
}

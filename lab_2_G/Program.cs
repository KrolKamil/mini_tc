using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_G
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

            Model model = new Model();
            IView view = new Form1();

            TCPanelPresenter TCPLeft = new TCPanelPresenter(view.LeftPanel, model);
            TCPanelPresenter TCPRight = new TCPanelPresenter(view.RightPanel, model);

            Presenter presenter = new Presenter(view, model);

            Application.Run((Form1)view);
        }
    }
}

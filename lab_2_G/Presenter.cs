using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_G
{
    class Presenter
    {
        IView view;
        Model model;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.CopyItem += CopyElement;
        }

        public void CopyElement()
        {
            //model.CopyData(view.LeftPanel, view.RightPanel);
        }
    }
}

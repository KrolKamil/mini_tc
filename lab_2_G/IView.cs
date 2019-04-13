using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_G
{
    interface IView
    {
        ITCPanelView LeftPanel { get; }
        ITCPanelView RightPanel { get; }

        event Action CopyItem;
    }

}

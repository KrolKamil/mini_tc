using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_G
{
    public interface ITCPanelView
    {
        string CurrentPath { get; set; }
        string CurrentDrive { get; }
        string ItemToCopy { get; }

        string[] DirectoryElements { set; }
        string[] Drives { set; }

        event Action SelectDrive;
        event Action PathChanged;
    }
}

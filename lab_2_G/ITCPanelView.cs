using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_G
{
    public interface ITCPanelView
    {
        string CurrentPath { get; set; }
        string CurrentDrive { get; }
        string ItemToCopy { get; }
        int DefaultDirectory { set; }

        string[] DirectoryElements { set; }
        string[] Drives { set; }

        AutoCompleteStringCollection AutocompleteSuggestPath { set; }

        event Action SelectDrive;
        event Action PathChanged;
        event Action SelectedItem;
    }
}

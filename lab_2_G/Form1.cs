using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_2_G
{
    public partial class Form1 : Form, IView
    {

        public event Action CopyItem;

        public String Error
        {
            set { label1.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
            /*
            minTCPanel1.CurrentPath = "c:\\";
            minTCPanel1.Drives = Directory.GetLogicalDrives();
            minTCPanel1.SelectDrive += MinTCPanel1_SelectDrive;

            minTCPanel2.Drives = Directory.GetLogicalDrives();
            */
        }

        ITCPanelView IView.LeftPanel => minTCPanel1;

        ITCPanelView IView.RightPanel => minTCPanel2;

        private void MinTCPanel1_SelectDrive()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CopyItem != null)
                CopyItem();
        }
    }
}

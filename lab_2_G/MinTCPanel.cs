using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_2_G
{
    public partial class MinTCPanel : UserControl, ITCPanelView
    {
        #region Prop

        public string ItemToCopy
        {
            get { return listBox1.GetItemText(listBox1.SelectedItem); }
        }

        public string CurrentPath {
            get {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        public string[] Drives
        {
            set {
                foreach (var d in value)
                    comboBox1.Items.Add(d);
            }
        }

        public string CurrentDrive
        {
            get
            {
                return comboBox1.Text;
            }
        }

        public string[] DirectoryElements
        {
            set
            {
                if(value != null)
                {
                    listBox1.Items.Clear();
                    foreach (var d in value)
                        listBox1.Items.Add(d);
                }
            }
        }

        #endregion

        #region Events

        public event Action SelectDrive;
        public event Action PathChanged;

        #endregion
        public MinTCPanel()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (PathChanged != null)
                PathChanged();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Console.WriteLine("XD");
                if (PathChanged != null)
                    PathChanged();
                listBox1.Focus();
            }
        }
    }
}

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

        public AutoCompleteStringCollection AutocompleteSuggestPath
        {
            //set { textBox1.AutoCompleteCustomSource = value; }

            set { textBox1.AutoCompleteCustomSource = value; }
        }

        public string ItemToCopy
        {
            get { return listBox1.GetItemText(listBox1.SelectedItem); }
        }

        public int DefaultDirectory
        {
            set{ comboBox1.SelectedIndex = value; }
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
        public event Action SelectedItem;

        #endregion
        public MinTCPanel()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectDrive != null)
                SelectDrive();
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
                if (PathChanged != null)
                    PathChanged();
                listBox1.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (SelectedItem != null)
                    SelectedItem();
            }
        }
    }
}

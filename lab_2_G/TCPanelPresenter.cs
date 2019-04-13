using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_G
{
    class TCPanelPresenter
    {
        ITCPanelView view;
        Model model;

        public TCPanelPresenter(ITCPanelView view, Model model)
        {
            this.view = view;
            this.model = model;

            initDrives();
            SetDefaultPath();
            SetDefaultDirectory();
            LoadDirectoryElements();

            this.view.SelectDrive += SetPath;
            this.view.PathChanged += LoadDirectoryElements;
        }

        private void initDrives()
        {
            view.Drives = model.GetDrives();
        }

        private void SetPath()
        {
            this.view.CurrentPath = this.view.CurrentDrive;
            this.view.DirectoryElements = this.model.GetDirectoryElements(view.CurrentPath);
        }

        private void LoadDirectoryElements()
        {
            this.view.DirectoryElements = this.model.GetDirectoryElements(view.CurrentPath);
        }

        private void SetDefaultPath()
        {
            this.view.CurrentPath = model.GetDefaultDrive();
        }

        private void SetDefaultDirectory()
        {
            this.view.DefaultDirectory = 0;
        }
    }
}

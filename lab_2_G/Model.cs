using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_2_G
{
    public class Model
    {

        public void ChangeDirecotry(string coreDirectory, string toGoDirectory)
        {

        }

        public string[] GetDrives()
        {
            return Directory.GetLogicalDrives();
        }

        public string GetDefaultDrive()
        {
            string[] drives = this.GetDrives();
            Console.WriteLine(drives[0]);
            return drives[0];
        }

        public string[] GetDirectoryElements(string InputPath)
        {
            if(Directory.Exists(InputPath))
            { 
                
                string[] Directories = Directory.GetDirectories(InputPath);
                string[] Files = Directory.GetFiles(InputPath);

                for (int i = 0; i < Directories.Length; i++)
                {
                    Directories[i] = "D: " + Path.GetFileName(Directories[i]);
                }

                for (int i = 0; i < Files.Length; i++)
                {
                    Files[i] = "F: " + Path.GetFileName(Files[i]);
                }

                var List = new List<string>();
                List.AddRange(Directories);
                List.AddRange(Files);

                return List.ToArray();
                
                /*
                string[] Elements = Directory.GetFileSystemEntries(InputPath);
                return Elements;
                */
            }
            return null;
        }

        
        public void CopyData(ITCPanelView left, ITCPanelView right)
        {
            String SelectedItemToCopy = left.ItemToCopy.Trim();
            String SelectedPathFromCopy = left.CurrentPath.Trim();

            String DestinatnionPath = right.CurrentPath;

            Console.WriteLine(SelectedPathFromCopy);
            Console.WriteLine(SelectedItemToCopy);

            if ( (SelectedPathFromCopy != "") && (SelectedItemToCopy != "") )
            {
                if(SelectedItemToCopy[0] == 'F')
                {
                    SelectedItemToCopy = SelectedItemToCopy.Substring(3);
                    //add back slash for path
                    if (!SelectedPathFromCopy[SelectedPathFromCopy.Length - 1].Equals('\\'))
                    {
                        SelectedPathFromCopy += "\\";
                    }

                    if (!DestinatnionPath[DestinatnionPath.Length - 1].Equals('\\'))
                    {
                        DestinatnionPath += "\\";
                    }

                    String PathAndItem = String.Concat(SelectedPathFromCopy, SelectedItemToCopy);
                    DestinatnionPath = String.Concat(DestinatnionPath, SelectedItemToCopy);
                    //TUTAJ JEST Z DUPY POTENCJALNY BLAD XD

                    if(DestinatnionPath != "")
                    {
                        File.Copy(PathAndItem, DestinatnionPath);
                        Console.WriteLine("Cos sobie skopiowalem Beka");
                    }

                }
            }

            

            //Console.WriteLine(PathAndItem);
        }
        

    }
}

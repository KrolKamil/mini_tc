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

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }


        public string CopyData(ITCPanelView left, ITCPanelView right)
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

                    if(DestinatnionPath != "")
                    {
                        if(!File.Exists(DestinatnionPath))
                        {
                            try
                            {
                                File.Copy(PathAndItem, DestinatnionPath);
                            }
                            catch(Exception e)
                            {
                                return "Brak dostepu";
                            }

                        }
                        else
                        {
                            return "Nie mozna nadpisac pliku";
                        }
                    }
                }
                else
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
                    DestinatnionPath = DestinatnionPath + "\\" + SelectedItemToCopy;

                    if (DestinatnionPath != "")
                    {
                        try
                        {
                            Directory.CreateDirectory(DestinatnionPath);
                            DirectoryCopy(PathAndItem, DestinatnionPath, true);
                        }
                        catch(Exception e)
                        {
                            return "Brak praw do kopiowania";
                        }
                    }

                }
            }
            else
            {
                return "Wybierz element do skopiowania";
            }

            return "";

            //Console.WriteLine(PathAndItem);
        }
        

    }
}

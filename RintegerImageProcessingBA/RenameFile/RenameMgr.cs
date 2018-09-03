using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RintegerImageProcessingBA.RenameFile
{
    public class RenameMgr
    {
        List<String> files = new List<String>();
        public List<String> DirSearch(string sDir, string prefix, string suffix)
        {
            
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    files.Add(f);
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        
                            files.Add(f);
                        
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            RenameFiles(files, prefix, suffix);
            return files;
        }

        private void RenameFiles(List<string> fileNames, string prefix , string suffix)
        {
            string newFileName = string.Empty;
            string fileNameWithoutExtension = string.Empty;
            string filePath = string.Empty;
            string newFilePath = string.Empty;
            foreach(string fileName in fileNames)
            {
                fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                filePath = Path.GetDirectoryName(fileName);
                newFileName = prefix + fileNameWithoutExtension + suffix;
                newFilePath = filePath + "\\" + newFileName + Path.GetExtension(fileName);
                File.Move(fileName, newFilePath);
            }
            
        }
        //public bool CopyFolder(string sourceFolder, string destFolder)
        //{
        //    try
        //    {
        //        System.IO.Directory.(sourceFile, destFile, true);
        //    }
            
        //}
    }
}

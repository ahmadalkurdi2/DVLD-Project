using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Global_Classes
{
    public class clsUtil
    {
        public static bool CreateFolderIfNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (IOException iox)
                {
                    MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }
        public static bool CopyImageToProjectImagesFolder(ref string SourceFile)
        {
            string DestinationFolder = @"D:\DVLD-People-Images\";
            if (!CreateFolderIfNotExist(DestinationFolder))
                return false;
            string DestinationFile = DestinationFolder + ReplaceFileNameWithGuid(SourceFile);
            try
            {
                File.Copy(SourceFile, DestinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            SourceFile = DestinationFile;
            return true;
        }

        public static string GenerateGUID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public static string ReplaceFileNameWithGuid(string SourceFile)
        {
            FileInfo fileInfo = new FileInfo(SourceFile);
            return GenerateGUID() + fileInfo.Extension;
        }

    }
}

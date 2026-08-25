using DVLD_Business;

namespace DVLD.Global_Classes
{// C#
    public static class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string UserName, string Password)
        {
            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
                string FilePath = CurrentDirectory + "\\data.txt";

                if (UserName == string.Empty && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }
                string DataToSave = UserName + "#//#" + Password;
                using (StreamWriter Writer = new StreamWriter(FilePath))
                {
                    Writer.WriteLine(DataToSave);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string UserName, ref string Password)
        {
            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
                string FilePath = CurrentDirectory + "\\data.txt";

                if (File.Exists(FilePath))
                {
                    using (StreamReader Reader = new StreamReader(FilePath))
                    {
                        // 1. Read ONLY the first line. We only ever save one line, so a loop is unnecessary.
                        string Line = Reader.ReadLine();

                        // 2. Safety check: Ensure the file isn't completely empty
                        if (!string.IsNullOrEmpty(Line))
                        {
                            string[] Result = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            // 3. Data Integrity check: Ensure the split actually produced exactly 2 parts
                            if (Result.Length == 2)
                            {
                                UserName = Result[0];
                                Password = Result[1];
                                return true; // Success!
                            }
                        }
                    }
                }

                // If the file didn't exist, was empty, or was malformed, return false
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}

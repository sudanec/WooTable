using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Microsoft.VisualBasic.FileIO;
using System.Threading;
using System.Windows.Forms;

namespace WooTable
{
    class FileSync
    {
        private string FileVariant = "";
        private string localFolder = "";
        private string tempFolder = "";
        private Tuple<string, string> credentials;
        private WebClient client;
        private const int BYTES_TO_READ = sizeof(Int64);

        public FileSync(string _variant)
        {
            FileVariant = _variant;
            localFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFolder);
            credentials = PasswordManager.GetPassword(Properties.Settings.Default.WooTable_OracleData);
            client = new WebClient();
            client.Credentials = new NetworkCredential(credentials.Item1, credentials.Item2);

            CreateAppdataFolder();
        }

        ~FileSync()
        {
            client.Dispose();
        }

        protected void CreateAppdataFolder()
        {
            string controlFile;
            Directory.CreateDirectory(localFolder);

            if (FileVariant == Properties.Settings.Default.WooTable_OracleData)
            {
                tempFolder = Path.Combine(localFolder, Properties.Settings.Default.WooTable_OracleData);
                tempFolder = Path.Combine(tempFolder, Properties.Settings.Default.AppDataFilesFolder);
                Directory.CreateDirectory(tempFolder);
                controlFile = Path.Combine(tempFolder, Properties.Settings.Default.OracleData_Checksums);
                if (!File.Exists(controlFile))
                {
                    StreamWriter sw = File.CreateText(controlFile);
                    sw.WriteLine("0");
                    sw.Close();
                }
                tempFolder = Path.Combine(tempFolder, "Icons");
                Directory.CreateDirectory(tempFolder);
                controlFile = Path.Combine(tempFolder, Properties.Settings.Default.OracleData_Checksums);
                if (!File.Exists(controlFile))
                {
                    StreamWriter sw = File.CreateText(controlFile);
                    sw.WriteLine("0");
                    sw.Close();
                }
            }
            else { return; }
        }

        // checks if files were updated. If yes, downloads updates

        private void updateSubfolder(string path, string extrapath = "")
        {
            string actFile = "";
            int i, filesCount;
            if (extrapath.Length > 0)
            {
                path = path + "\\" + extrapath;
                extrapath = extrapath + "/";
            }

            //let's update changed files; first let's remove existing files
            System.IO.DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Name != Properties.Settings.Default.UpdateTempFile && file.Name != "checksums.csv")
                {
                    file.Delete();
                }
            }

            //now let's download new files
            using (TextFieldParser parser = new TextFieldParser(path + "\\" + Properties.Settings.Default.UpdateTempFile))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                string[] fields = parser.ReadFields();
                filesCount = int.Parse(fields[0]);

                for (i = 0; i < filesCount; i++)
                {
                    try
                    {
                        //Process row
                        fields = parser.ReadFields();
                        actFile = fields[0];
                        client.DownloadFile(Properties.Settings.Default.OracleDataLocation + extrapath + actFile, path + "\\" + actFile);
                    }
                    catch
                    {

                    }
                }

            }
            //let's update the config file
            FileInfo tFile = new FileInfo(path + "\\checksums.csv");
            tFile.Delete();
            tFile = new FileInfo(path + "\\" + Properties.Settings.Default.UpdateTempFile);
            tFile.MoveTo(tFile.Directory.FullName + "\\checksums.csv");
        }

        public async Task<Boolean> checkUpdates()
        {
            if (SynchronizationContext.Current == null)
                SynchronizationContext.SetSynchronizationContext(new WindowsFormsSynchronizationContext());

            Boolean resulter = false;

            if (FileVariant == Properties.Settings.Default.WooTable_OracleData)
            {
                if (!(fcie.isInternetConnected())) { return false; }
                try
                {
                    tempFolder = Path.Combine(localFolder, Properties.Settings.Default.WooTable_OracleData);
                    tempFolder = Path.Combine(tempFolder, Properties.Settings.Default.AppDataFilesFolder);
                    //await client.DownloadFileAsync(new Uri(Properties.Settings.Default.OracleDataLocation + "checksums.csv"), tempFolder + "\\" + Properties.Settings.Default.UpdateTempFile);
                    client.DownloadFile(Properties.Settings.Default.OracleDataLocation + "checksums.csv", tempFolder + "\\" + Properties.Settings.Default.UpdateTempFile);
                    if (compareConfigFiles(tempFolder + "\\" + Properties.Settings.Default.UpdateTempFile, tempFolder + "\\checksums.csv"))
                    {
                        // no update is needed
                        resulter = true;
                    }
                    else
                    {
                        updateSubfolder(tempFolder);

                        resulter = false;
                    }

                    client.DownloadFile(Properties.Settings.Default.OracleDataLocation + "/Icons/checksums.csv", tempFolder + "\\Icons\\" + Properties.Settings.Default.UpdateTempFile);
                    if (compareConfigFiles(tempFolder + "\\Icons\\" + Properties.Settings.Default.UpdateTempFile, tempFolder + "\\Icons\\checksums.csv"))
                    {
                        // no update is needed
                        resulter = resulter || true;
                    }
                    else
                    {
                        updateSubfolder(tempFolder, "Icons");

                        resulter = resulter || false;
                    }
                    return resulter;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    File.Delete(tempFolder + "\\" + Properties.Settings.Default.UpdateTempFile);
                    File.Delete(tempFolder + "\\Icons\\" + Properties.Settings.Default.UpdateTempFile);
                }
            } else
            {
                return false;
            }
        }

        private Boolean compareConfigFiles(string path1, string path2)
        {
            FileInfo first, second;
            if (!(File.Exists(path1)) || !(File.Exists(path2))) return false;
            first = new FileInfo(path1);
            second = new FileInfo(path2);

            if (first.Length != second.Length)
                return false;

            if (string.Equals(first.FullName, second.FullName, StringComparison.OrdinalIgnoreCase))
                return true;

            int iterations = (int)Math.Ceiling((double)first.Length / BYTES_TO_READ);

            using (FileStream fs1 = first.OpenRead())
            using (FileStream fs2 = second.OpenRead())
            {
                byte[] one = new byte[BYTES_TO_READ];
                byte[] two = new byte[BYTES_TO_READ];

                for (int i = 0; i < iterations; i++)
                {
                    fs1.Read(one, 0, BYTES_TO_READ);
                    fs2.Read(two, 0, BYTES_TO_READ);

                    if (BitConverter.ToInt64(one, 0) != BitConverter.ToInt64(two, 0))
                        return false;
                }
            }

            return true;
        }
    }
}

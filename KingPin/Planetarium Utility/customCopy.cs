using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*************************************************************************************/
/* Credit to: http://stackoverflow.com/questions/6044629/file-copy-with-progress-bar */
/* Anton Semenov                                                                     */
/*************************************************************************************/

namespace Planetarium_Utility
{
    public delegate void ProgressChangeDelegate(double Persentage, ref bool Cancel,
                                                string fileName, long fileLength, long totalBytes,
                                                string fileSize, string secondsRemaining, string transferSpeed);
    public delegate void Completedelegate(string fileName, string fileSize, string message);

    class CustomFileCopier
    {
        //Constants
        const long KB = 1024;
        const long MB = KB * 1000;
        const long GB = MB * 1000;
        const long TB = GB * 1000;
        
        public CustomFileCopier(string Source, string Dest, string fileName)
        {
            this.SourceFilePath = Source;
            this.DestFilePath = Dest;
            this.fileName = fileName;

            OnProgressChanged += delegate { };
            OnComplete += delegate { };
        }

        public void Copy()
        {
            // Delete if exist aka overwrite later
            if (File.Exists(DestFilePath))
            {
                File.Delete(DestFilePath);
            }

            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            bool cancelFlag = false;

            using (FileStream source = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read))
            {
                long fileLength = source.Length;

                string fileSize = roundFileLength((double)fileLength);
                string secondsRemaining = null;
                string trasferSpeed = null;
                double mbs = 0.0;
                DateTime startTime = DateTime.Now;

                using (FileStream dest = new FileStream(DestFilePath, FileMode.CreateNew, FileAccess.Write))
                {
                    long totalBytes = 0;
                    int currentBlockSize = 0;
                    long fileCopied = dest.Length;

                    while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytes += currentBlockSize;
                        double percentage = (double)totalBytes * 100.0 / fileLength;
                        
                        // Write action
                        dest.Write(buffer, 0, currentBlockSize);

                        // Calculate ETA
                        TimeSpan ETA = startTime.Subtract(DateTime.Now);
                        double mbRemaining = (totalBytes - fileLength) / MB;
                        if (ETA != TimeSpan.Zero)
                        {
                            mbs = Math.Round(((double)totalBytes / MB) / ETA.Seconds, 2);
                            secondsRemaining = Math.Round(((mbRemaining / mbs)), 0).ToString() + "s remaining";
                        }
                        
                        // Calculate transfer speed
                        trasferSpeed = (-mbs).ToString() + " MB/s";
                        if (trasferSpeed.Equals("-Infinity MB/s"))
                            trasferSpeed = "0 MB/s";

                        cancelFlag = false;
                        OnProgressChanged(percentage, ref cancelFlag, fileName, fileLength,
                                          totalBytes, fileSize, secondsRemaining, trasferSpeed);

                        if (cancelFlag == true)
                        {
                            // Delete dest file
                            File.Delete(DestFilePath);

                            break;
                        }
                    }
                }

                OnComplete(fileName, fileSize, "Completed");
            }

            
        }

        private string roundFileLength(double size)
        {
            

            string stringSize = null;
            double roundedSize;

            if (size <= 1)
                stringSize = size.ToString() + " Byte";
            else if (size > 1 && size <= KB)
                stringSize = size.ToString() + " Bytes";
            else if (size > KB && size <= MB)
            {
                roundedSize = Math.Round(size / KB, 0);
                stringSize = roundedSize.ToString() + " KB";
            }
            else if (size > MB && size <= GB)
            {
                roundedSize = Math.Round(size / MB, 0);
                stringSize = roundedSize.ToString() + " MB";
            }
            else if (size > GB && size <= TB)
            {
                roundedSize = Math.Round(size / GB, 0);
                stringSize = roundedSize.ToString() + " GB";
            }
            else if (size >= TB)
            {
                roundedSize = Math.Round(size / TB, 0);
                stringSize = roundedSize.ToString() + " TB";
            }
                
            return stringSize;

        }

        public string SourceFilePath { get; set; }
        public string DestFilePath { get; set; }
        public string fileName { get; set; }


        public event ProgressChangeDelegate OnProgressChanged;
        public event Completedelegate OnComplete;
    }
    
}

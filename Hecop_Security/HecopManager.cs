using HecopUI_Winforms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Hecop_Security
{
    internal class HecopManager
    {

        public static string[] QuickScanData
            =
        {
            "C:\\ProgramData\\","C:\\Windows\\System32\\"
        };

        public static string[] SearchFiles(string path)
        {
            string[] a=null ;
            if(System.IO.Directory.Exists(path))
            {
                a= System.IO.Directory.GetFiles(path);
            }
            if(System.IO.File.Exists(path))
            {
                a= new string[] { path };
            }
            return a;
        }

        public static string GetDataBaseVersion()
        {
            string s = "";
            try
            {
                s = (SendCommand("VERSION") != "...") ? SendCommand("VERSION") : "...";


            }
           
            catch { }
            return s;
        }

        public static string SendCommand(string command)
        {
            string host = "127.0.0.1";
            int port = 3310;
            string vr = "";
            try
            {
                using (TcpClient client = new TcpClient(host, port))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] data = Encoding.UTF8.GetBytes(command);
                        stream.Write(data, 0, data.Length);
                        StreamReader streamReader = new StreamReader(stream);
                        vr = streamReader.ReadToEnd();
                    }
                }
            }
            catch { vr = "..."; }
            return vr;
        }

        public partial class FilesOfNum
        {
            int i = 0;
            public FilesOfNum(string path)
            {
                i = 0;
                Scan(path);
            }

            public int FilesOfNumInDir
            {
                get { return i; }
            }

            void Scan(string path)
            {
                try
                {

                    foreach (string file in System.IO.Directory.GetFiles(path))
                    {
                        i++;

                    }
                    foreach (string dir in System.IO.Directory.GetDirectories(path))
                    {

                        Scan(dir);
                    }
                }
                catch
                {

                }
            }

        }

        public static List<virQua> VirrQuaList = new List<virQua>();

        public class virQua
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public string VirusName { get; set; }
            public string SizeOfFile { get; set; }
            public DateTime DateTime { get; set; }
        }
    }
}

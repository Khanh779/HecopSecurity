using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Security
{
    public partial class UpdateUI : UserControl
    {

        static UpdateUI _instance = null;
        public static UpdateUI Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new UpdateUI();
                _instance.BringToFront();
                return _instance;
            }
        }


        public UpdateUI()
        {
            InitializeComponent();
            _instance=this;
            HButton1.MouseClick += HButton1_MouseClick;
            HButton2.MouseClick += HButton2_MouseClick;
        }

        private void HButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //hProgressBar1.AnimationMode = HecopUI_Winforms.Enums.ProgressAnimationMode.None;
                new Task((() =>
                {
                    foreach (Process pd in Process.GetProcesses())
                    {
                        //System.IO.File.AppendAllLines("C:\\a.txt", new string[] { pd.ProcessName});
                        if (pd.ProcessName == "freshclam")
                            pd.Kill();

                    }
                })).Start();
            }
        }

        private void HButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
               // hProgressBar1.AnimationMode = HecopUI_Winforms.Enums.ProgressAnimationMode.Indeterminate;
                if (label4.InvokeRequired)
                    label4.Invoke((Action)(() => label4.Text = "Trạng thái: Đang cập nhật...\n" + "Đang tải các gói..."));
            
                new Task((() =>
                {
                    StartUpdateClamAV();
                })).Start();
              
            }    
        }

        public void StartUpdateClamAV()
        {
            try
            {
                bool a = false;

                foreach (Process pd in Process.GetProcesses())
                {
                    //System.IO.File.AppendAllLines("C:\\a.txt", new string[] { pd.ProcessName});
                    if (pd.ProcessName == "freshclam")
                        a = true;

                }

                //foreach (Process s in Process.GetProcessesByName("clamd.exe")) s.Kill();



                if (a == false)
                {
                    Process prc = new Process();

                    prc.StartInfo = new ProcessStartInfo();
                    prc.StartInfo.FileName = Application.StartupPath + "\\ClamAV\\" + (Environment.Is64BitOperatingSystem == false ? "x86" : "x64") + "\\freshclam.exe";
                    prc.StartInfo.UseShellExecute = false;
                    prc.StartInfo.RedirectStandardOutput = true;
                    prc.Exited += Prc_Exited;
                    prc.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                    prc.StartInfo.RedirectStandardOutput = true;
                    prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    prc.StartInfo.CreateNoWindow = true;
                    prc.EnableRaisingEvents = true;

                    prc.Start();
                }


            }
            catch { }
        }

        private void Prc_Exited(object sender, EventArgs e)
        {
            //hProgressBar1.AnimationMode = HecopUI_Winforms.Enums.ProgressAnimationMode.None;
            if (label4.InvokeRequired)
                label4.Invoke((Action)(() =>
        label4.Text = "Trạng thái: Cập nhật hoàn tất!\n"+ HecopManager.GetDataBaseVersion()));
        }
    }
}

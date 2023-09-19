using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Hecop_Security.ScanMode
{
    public partial class QuickScanForm : HecopUI_Winforms.Forms.HForm
    {

        static QuickScanForm _instance = null;
        public static QuickScanForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new QuickScanForm();
                _instance.BringToFront();
                return _instance;
            }
        }

        public QuickScanForm()
        {
           
            InitializeComponent();
            _instance = this;
            Load += QuickScanForm_Load;
        }

        private void QuickScanForm_Load(object sender, EventArgs e)
        {
            HButton4.MouseClick += HButton4_MouseClick;
            HButton3.MouseClick += HButton3_MouseClick;
            hImage1.Location = hCircularProgressBar1.Location;
            hImage1.BringToFront();
        }

        private void HButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
        }

        private void HButton4_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    hCircularProgressBar1.BringToFront();
                    hLabel1.Visible = true;
                    v = 0;
                    label4.Text = "Đang quét...";
                    label4.ForeColor = Color.FromArgb(10, 174, 104);
                    label6.Text = label5.Text = "0";
                    backgroundWorker1.RunWorkerAsync();
                    //hCircularProgressBar1.AnimationMode = HecopUI_Winforms.Controls.HCircularProgressBar.AnimationType.Indicator;
                   
                }  
            }    
        }

        void Scan(string path)
        {
            try
            {
              
                foreach (string file in System.IO.Directory.GetFiles(path))
                {
                    if (backgroundWorker1.CancellationPending) return;
                    FileInfo FI= new FileInfo(file);
                    try
                    {
                       
                        FI.OpenRead();
                        label6.Invoke((Action)(() => label6.Text = (int.Parse(label6.Text) + 1).ToString()));

                        hLabel1.Invoke((Action)(() =>
                        {
                            hLabel1.Text = FI.FullName;
                        }));


                        if( HecopManager.SendCommand("SCAN "+file).Contains("FOUND"))
                        {

                        }

                      
                        
                    }
                    catch { }

                    backgroundWorker1.ReportProgress(hCircularProgressBar1.ProgressBarValue = (int)(int.Parse(label6.Text) * 98 / v));

                    label5.Invoke((Action)(() => label5.Text = HecopManager.VirrQuaList.Count.ToString()));

                }
                foreach(string dir in System.IO.Directory.GetDirectories(path))
                {
                  
                    Scan(dir);
                }
            }
            catch
            {

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
          
            backgroundWorker1.CancelAsync();
            
            base.OnFormClosing(e);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
           
            foreach(string b in HecopManager.QuickScanData)
            {
                v += new HecopManager.FilesOfNum(b).FilesOfNumInDir;
            }
            //MessageBox.Show(v.ToString());
            foreach (string a in HecopManager.QuickScanData)
            {
                Scan(a);
            }
            backgroundWorker1.ReportProgress(100);
        }

        int v = 0;

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            hCircularProgressBar1.ProgressBarValue = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //hCircularProgressBar1.AnimationMode = HecopUI_Winforms.Controls.HCircularProgressBar.AnimationType.None;
            //hImage1.BringToFront();
            //hCircularProgressBar1.ProgressBarValue = 100;
            if(HecopManager.VirrQuaList.Count > 0)
            {
                label4.Text = "Đã phát hiện virus!";
                label4.ForeColor = Color.FromArgb(230, 93, 93);
            }
            if(HecopManager.VirrQuaList.Count== 0)
            {
                label4.Text = "An toàn!";
                label4.ForeColor = Color.FromArgb(10,174,104);
            }    
            hLabel1.Visible = false;
        }
    }
}

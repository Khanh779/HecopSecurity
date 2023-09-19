using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hecop_Security
{
    public partial class Form1 : Form
    {


        static Form1 _instance = null;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new Form1();
                _instance.BringToFront();
                return _instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
          
            _instance= this;
            LB_Title.Text = Text = ProductName;
            label1.Text = "Version:\n" + ProductVersion;
            pictureBox1.Image = Icon.ToBitmap();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTab(HomeUI.Instance);
       
        }

        public void LoadTab(Control ct)
        {
            if (!PN_Tabs.Controls.Contains(ct))
                PN_Tabs.Invoke((Action)(() =>
                {
                    PN_Tabs.Controls.Clear();

                    PN_Tabs.Controls.Add(ct);
                }
                ));

            
            ct.Dock = DockStyle.Fill;
            //ct.SendToBack();
        }

      
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(
                new SolidBrush(Color.FromArgb(66, 136, 231)), 1)
            { Alignment= System.Drawing.Drawing2D.PenAlignment.Inset},new Rectangle(0,0,Width-1,Height-1));
      
            base.OnPaint(e);
        }

        private void HButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                LoadTab(HomeUI.Instance);
            }    
        }

        private void HButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                LoadTab(ScanUI.Instance);
        }

        private void HButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                LoadTab(UpdateUI.Instance);
        }

        private void HButton4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                LoadTab(SecurityUI.Instance);
        }

        private void HButton5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                LoadTab(ToolsUI.Instance);
        }

        private void HButton6_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                LoadTab(SettingsUI.Instance);
        }

    }
}

using Hecop_Security.ScanMode;
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
    public partial class ScanUI : UserControl
    {

        static ScanUI _instance = null;
        public static ScanUI Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ScanUI();
                _instance.BringToFront();
                return _instance;
            }
        }

        public ScanUI()
        {
            InitializeComponent();
            _instance= this;
            hTitleSubButton2.MouseClick += HTitleSubButton2_MouseClick;
        }

        private void HTitleSubButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                QuickScanForm.Instance.Show();
        }
    }
}

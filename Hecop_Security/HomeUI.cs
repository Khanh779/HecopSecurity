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
    public partial class HomeUI : UserControl
    {
        static HomeUI _instance=null;
        public static HomeUI Instance
        {
            get
            {
                if (_instance == null|| _instance.IsDisposed)
                    _instance = new HomeUI();
                _instance.BringToFront();
                return _instance;
            }
        }

        public HomeUI()
        {
            InitializeComponent();
            _instance= this;
            Controls.Add(LoadingSecurity.Instance);
            LoadingSecurity.Instance.BringToFront();
            Load += HomeUI_Load;
        }

        private void HomeUI_Load(object sender, EventArgs e)
        {
         
        }
    }
}

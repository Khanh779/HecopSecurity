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
    public partial class SecurityUI : UserControl
    {

        static SecurityUI _instance = null;
        public static SecurityUI Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new SecurityUI();
                _instance.BringToFront();
                return _instance;
            }
        }

        public SecurityUI()
        {
            InitializeComponent();
            _instance = this;
            Load += SecurityUI_Load;
        }

        private void SecurityUI_Load(object sender, EventArgs e)
        {
         
          
        }

     

      
    }
}

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
    public partial class SettingsUI : UserControl
    {
        static SettingsUI _instance = null;
        public static SettingsUI Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new SettingsUI();
                _instance.BringToFront();
                return _instance;
            }
        }

        public SettingsUI()
        {
            InitializeComponent();
            _instance= this;
        }
    }
}

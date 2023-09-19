using HecopUI_Winforms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Security.ToolsUIT
{
    public partial class LogForm : HForm
    {

        static LogForm _instance = null;
        public static LogForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new LogForm();
                _instance.BringToFront();
                return _instance;
            }
        }

        public LogForm()
        {
            InitializeComponent();
            _instance= this;
        }
    }
}

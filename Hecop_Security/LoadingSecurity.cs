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
    public partial class LoadingSecurity : UserControl
    {
        static LoadingSecurity _instance = null;
        public static LoadingSecurity Instance
        {
            get
            {
                if(_instance==null|| _instance.IsDisposed)_instance= new LoadingSecurity();
                _instance.BringToFront();
                return _instance;
            }
        }

        public LoadingSecurity()
        {
            InitializeComponent();
            _instance= this;
         

            Load += LoadingSecurity_Load;
        }

        private void LoadingSecurity_Load(object sender, EventArgs e)
        {
            dotProgressRing1.Location = new Point(Width / 2 - dotProgressRing1.Width / 2, dotProgressRing1.Location.Y);
           label1.Location= new Point(Width/2- label1.Width/2, label1.Location.Y);
            Location= new Point(Parent.Width/2- Width/2, 70);
        }

        
    }
}

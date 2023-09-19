using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Security.Security
{
    public partial class ProManButton : UserControl
    {
        public ProManButton()
        {
            InitializeComponent();
           
            
           
        }

        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ProText
        {
            get { return LB_ProText.Text; }
            set
            {
                LB_ProText.Text = value;
            }
        }

        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string SubText
        {
            get { return LB_Sub.Text; }
            set
            {
               LB_Sub.Text = value;
            }
        }

        public EventHandler CheckedChanged;

        public bool Checked
        {
            get { return hToggleButton1.IsOn; }
            set {hToggleButton1.IsOn= value; CheckedChanged?.Invoke(this, EventArgs.Empty); }
        }    

        private void hToggleButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                CheckedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public Image Image
        {
            get { return hImage1.Image; }
            set
            {
                hImage1.Image = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(
                new Pen(new SolidBrush(Color.Gainsboro), 1) { Alignment = System.Drawing.Drawing2D.PenAlignment.Inset },
                new Rectangle(0, 0, Width-1, Height-1));
            base.OnPaint(e);
        }
    }
}

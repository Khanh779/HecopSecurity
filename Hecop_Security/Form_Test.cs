using ClamAV_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Security
{
    public partial class Form_Test : Form
    {
        public Form_Test()
        {
            InitializeComponent();
            string database = "D:\\data\\Tailieu\\Projects\\C#\\Hecop_Security\\Hecop_Security\\bin\\Debug\\ClamAV\\database";
            //int num = UnsafeNativeMethods.cl_init(0);
            //uint sig = 0;
            //_engine = UnsafeNativeMethods.cl_engine_new();
            //UnsafeNativeMethods.cl_engine_set_num(_engine, UnsafeNativeMethods.cl_engine_field.CL_ENGINE_MAX_SCANSIZE, 1024 * 1023* 1024);
            //UnsafeNativeMethods.cl_engine_set_num(_engine, UnsafeNativeMethods.cl_engine_field.CL_ENGINE_MAX_FILESIZE, 1024 * 1023 * 1024);
            //UnsafeNativeMethods.cl_load(database, _engine,out sig, 0);

            ce = new ClamEngine();
            ce.LoadDatabase(database);
            ce.MaxScanSize = ce.MaxFileSize = 1024 * 1024 * 1024;
            Load += Form_Test_Load;
        }

        private void Form_Test_Load(object sender, EventArgs e)
        {
        
        }

        IntPtr _engine= IntPtr.Zero;
        ClamEngine ce;

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
           
                string vir = " "; ulong scanned = 0;
                //UnsafeNativeMethods.cl_scanfile(openFileDialog1.FileName, out vir, out scanned, _engine, (IntPtr)UnsafeNativeMethods.CL_SCAN_ALLMATCHES);

                ce.ScanFile(openFileDialog1.FileName, ScanOptions.StandardOptions, out vir);
                MessageBox.Show(String.Format("Số tệp tin đã quét: {0}\nSố tệp tin bị nhiễm: {1}\nTên virus (Nếu có): {2}\nModule: {3}", scanned, (vir==" "?0:1), 
                   vir,"Clam"));
            }
        }
    }
}

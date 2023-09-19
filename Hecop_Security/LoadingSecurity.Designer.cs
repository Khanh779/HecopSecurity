namespace Hecop_Security
{
    partial class LoadingSecurity
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dotProgressRing1 = new HecopUI_Winforms.Controls.HDotProgressRing();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dotProgressRing1
            // 
            this.dotProgressRing1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dotProgressRing1.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.dotProgressRing1.DotCount = 8;
            this.dotProgressRing1.Interval = 100;
            this.dotProgressRing1.Location = new System.Drawing.Point(142, 79);
            this.dotProgressRing1.Name = "dotProgressRing1";
            this.dotProgressRing1.ProgressStyle = HecopUI_Winforms.Controls.HDotProgressRing.Style.Style1;
            this.dotProgressRing1.Radius = 3;
            this.dotProgressRing1.Size = new System.Drawing.Size(42, 42);
            this.dotProgressRing1.StartAnimation = true;
            this.dotProgressRing1.TabIndex = 0;
            this.dotProgressRing1.Text = "dotProgressRing1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(59, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đang khởi tạo ClamAV...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoadingSecurity
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dotProgressRing1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoadingSecurity";
            this.Size = new System.Drawing.Size(328, 236);
            this.ResumeLayout(false);

        }

        #endregion

        private HecopUI_Winforms.Controls.HDotProgressRing dotProgressRing1;
        private System.Windows.Forms.Label label1;
    }
}

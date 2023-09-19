namespace Hecop_Security
{
    partial class HomeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUI));
            this.hImage1 = new HecopUI_Winforms.Controls.HImage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hImage1
            // 
            this.hImage1.HShapeType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.hImage1.Image = ((System.Drawing.Image)(resources.GetObject("hImage1.Image")));
            this.hImage1.ImageSize = new System.Drawing.Size(80, 80);
            this.hImage1.Location = new System.Drawing.Point(161, 89);
            this.hImage1.Name = "hImage1";
            this.hImage1.SetImageSizeMode = HecopUI_Winforms.Controls.HImage.ImageSizeMode.Custom;
            this.hImage1.Size = new System.Drawing.Size(232, 101);
            this.hImage1.TabIndex = 0;
            this.hImage1.Text = "hImage1";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(171)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(156, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Máy tính đang được bảo vệ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(13, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(13, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phiên bản cơ sở dữ liệu virus ClamAV:";
            // 
            // HomeUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hImage1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomeUI";
            this.Size = new System.Drawing.Size(558, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HecopUI_Winforms.Controls.HImage hImage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
    }
}

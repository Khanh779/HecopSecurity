namespace Hecop_Security.Security
{
    partial class ProManButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProManButton));
            this.LB_ProText = new System.Windows.Forms.Label();
            this.hImage1 = new HecopUI_Winforms.Controls.HImage();
            this.hToggleButton1 = new HecopUI_Winforms.Controls.HToggleButton();
            this.LB_Sub = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_ProText
            // 
            this.LB_ProText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_ProText.AutoEllipsis = true;
            this.LB_ProText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LB_ProText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LB_ProText.Location = new System.Drawing.Point(50, 3);
            this.LB_ProText.Name = "LB_ProText";
            this.LB_ProText.Size = new System.Drawing.Size(341, 18);
            this.LB_ProText.TabIndex = 4;
            this.LB_ProText.Text = "Bảo vệ tệp tin";
            // 
            // hImage1
            // 
            this.hImage1.HShapeType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.hImage1.Image = ((System.Drawing.Image)(resources.GetObject("hImage1.Image")));
            this.hImage1.ImageSize = new System.Drawing.Size(30, 30);
            this.hImage1.Location = new System.Drawing.Point(12, 7);
            this.hImage1.Name = "hImage1";
            this.hImage1.SetImageSizeMode = HecopUI_Winforms.Controls.HImage.ImageSizeMode.Custom;
            this.hImage1.Size = new System.Drawing.Size(32, 32);
            this.hImage1.TabIndex = 5;
            this.hImage1.Text = "hImage1";
            // 
            // hToggleButton1
            // 
            this.hToggleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hToggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.hToggleButton1.BorderColor = System.Drawing.Color.LightGray;
            this.hToggleButton1.BorderLeverColor = System.Drawing.Color.DarkGray;
            this.hToggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hToggleButton1.ForeColor = System.Drawing.Color.White;
            this.hToggleButton1.IsOn = false;
            this.hToggleButton1.LeverColor = System.Drawing.Color.White;
            this.hToggleButton1.Location = new System.Drawing.Point(440, 15);
            this.hToggleButton1.Name = "hToggleButton1";
            this.hToggleButton1.OffColor = System.Drawing.Color.Gray;
            this.hToggleButton1.OffText = "Tắt";
            this.hToggleButton1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(174)))), ((int)(((byte)(104)))));
            this.hToggleButton1.OnText = "Bật";
            this.hToggleButton1.Radius = 9F;
            this.hToggleButton1.Size = new System.Drawing.Size(36, 20);
            this.hToggleButton1.TabIndex = 6;
            this.hToggleButton1.Text = "hToggleButton1";
            this.hToggleButton1.TextEnabled = false;
            this.hToggleButton1.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hToggleButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hToggleButton1_MouseClick);
            // 
            // LB_Sub
            // 
            this.LB_Sub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Sub.AutoEllipsis = true;
            this.LB_Sub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LB_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.LB_Sub.Location = new System.Drawing.Point(50, 20);
            this.LB_Sub.Name = "LB_Sub";
            this.LB_Sub.Size = new System.Drawing.Size(355, 40);
            this.LB_Sub.TabIndex = 7;
            this.LB_Sub.Text = "Bảo vệ tệp tin";
            // 
            // ProManButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LB_ProText);
            this.Controls.Add(this.LB_Sub);
            this.Controls.Add(this.hToggleButton1);
            this.Controls.Add(this.hImage1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProManButton";
            this.Size = new System.Drawing.Size(490, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_ProText;
        private HecopUI_Winforms.Controls.HImage hImage1;
        private HecopUI_Winforms.Controls.HToggleButton hToggleButton1;
        private System.Windows.Forms.Label LB_Sub;
    }
}

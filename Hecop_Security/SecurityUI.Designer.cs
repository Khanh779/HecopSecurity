namespace Hecop_Security
{
    partial class SecurityUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityUI));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.proManButton1 = new Hecop_Security.Security.ProManButton();
            this.proManButton3 = new Hecop_Security.Security.ProManButton();
            this.proManButton2 = new Hecop_Security.Security.ProManButton();
            this.proManButton4 = new Hecop_Security.Security.ProManButton();
            this.proManButton5 = new Hecop_Security.Security.ProManButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bảo vệ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.proManButton1);
            this.flowLayoutPanel1.Controls.Add(this.proManButton3);
            this.flowLayoutPanel1.Controls.Add(this.proManButton2);
            this.flowLayoutPanel1.Controls.Add(this.proManButton4);
            this.flowLayoutPanel1.Controls.Add(this.proManButton5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(516, 310);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // proManButton1
            // 
            this.proManButton1.BackColor = System.Drawing.Color.White;
            this.proManButton1.Checked = true;
            this.proManButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proManButton1.Image = ((System.Drawing.Image)(resources.GetObject("proManButton1.Image")));
            this.proManButton1.Location = new System.Drawing.Point(3, 3);
            this.proManButton1.Name = "proManButton1";
            this.proManButton1.ProText = "Bảo vệ tệp tin";
            this.proManButton1.Size = new System.Drawing.Size(490, 64);
            this.proManButton1.SubText = "Giám sát và ngăn chặn các đối tượng bị nhiễm theo thời gian thực";
            this.proManButton1.TabIndex = 7;
            // 
            // proManButton3
            // 
            this.proManButton3.AutoSize = true;
            this.proManButton3.BackColor = System.Drawing.Color.White;
            this.proManButton3.Checked = true;
            this.proManButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proManButton3.Image = ((System.Drawing.Image)(resources.GetObject("proManButton3.Image")));
            this.proManButton3.Location = new System.Drawing.Point(3, 73);
            this.proManButton3.Name = "proManButton3";
            this.proManButton3.ProText = "Bảo vệ web";
            this.proManButton3.Size = new System.Drawing.Size(490, 64);
            this.proManButton3.SubText = "Bảo vệ và ngăn chặn người dùng truy cập đến trang web độc hại.";
            this.proManButton3.TabIndex = 9;
            // 
            // proManButton2
            // 
            this.proManButton2.BackColor = System.Drawing.Color.White;
            this.proManButton2.Checked = true;
            this.proManButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proManButton2.Image = ((System.Drawing.Image)(resources.GetObject("proManButton2.Image")));
            this.proManButton2.Location = new System.Drawing.Point(3, 143);
            this.proManButton2.Name = "proManButton2";
            this.proManButton2.ProText = "Giám sát ứng dụng";
            this.proManButton2.Size = new System.Drawing.Size(490, 64);
            this.proManButton2.SubText = "Giám sát và ngăn chặn các chương trình độc hại chạy trên hệ thống.";
            this.proManButton2.TabIndex = 8;
            // 
            // proManButton4
            // 
            this.proManButton4.BackColor = System.Drawing.Color.White;
            this.proManButton4.Checked = true;
            this.proManButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proManButton4.Image = ((System.Drawing.Image)(resources.GetObject("proManButton4.Image")));
            this.proManButton4.Location = new System.Drawing.Point(3, 213);
            this.proManButton4.Name = "proManButton4";
            this.proManButton4.ProText = "Tường lửa bảo vệ";
            this.proManButton4.Size = new System.Drawing.Size(490, 64);
            this.proManButton4.SubText = "Sàng lọc các kết nối đến và đi, cho phép các kết nối an toàn và ngăn chặn các kết" +
    " nối nguy hiểm.";
            this.proManButton4.TabIndex = 10;
            // 
            // proManButton5
            // 
            this.proManButton5.BackColor = System.Drawing.Color.White;
            this.proManButton5.Checked = true;
            this.proManButton5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proManButton5.Image = ((System.Drawing.Image)(resources.GetObject("proManButton5.Image")));
            this.proManButton5.Location = new System.Drawing.Point(3, 283);
            this.proManButton5.Name = "proManButton5";
            this.proManButton5.ProText = "Chống virus đám mây";
            this.proManButton5.Size = new System.Drawing.Size(490, 64);
            this.proManButton5.SubText = "Kết nối đến đám mây để phát hiện các mối đe dọa mới nhất";
            this.proManButton5.TabIndex = 11;
            // 
            // SecurityUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SecurityUI";
            this.Size = new System.Drawing.Size(558, 400);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Security.ProManButton proManButton3;
        private Security.ProManButton proManButton2;
        private Security.ProManButton proManButton1;
        private Security.ProManButton proManButton4;
        private Security.ProManButton proManButton5;
    }
}

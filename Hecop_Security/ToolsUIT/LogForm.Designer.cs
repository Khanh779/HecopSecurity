namespace Hecop_Security.ToolsUIT
{
    partial class LogForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hTabControl1 = new HecopUI_Winforms.Controls.HTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hListBox1 = new HecopUI_Winforms.Controls.HListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hListBox2 = new HecopUI_Winforms.Controls.HListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hListBox3 = new HecopUI_Winforms.Controls.HListBox();
            this.hTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hTabControl1
            // 
            this.hTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hTabControl1.AnimateEasingType = HecopUI_Winforms.Enums.EasingType.CubeOut;
            this.hTabControl1.AnimateTime = 200;
            this.hTabControl1.BackgroundColor = System.Drawing.Color.Transparent;
            this.hTabControl1.BorderTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hTabControl1.BorderThickness = 1;
            this.hTabControl1.Controls.Add(this.tabPage1);
            this.hTabControl1.Controls.Add(this.tabPage2);
            this.hTabControl1.Controls.Add(this.tabPage3);
            this.hTabControl1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.hTabControl1.Location = new System.Drawing.Point(20, 50);
            this.hTabControl1.Name = "hTabControl1";
            this.hTabControl1.SelectedIndex = 0;
            this.hTabControl1.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hTabControl1.Size = new System.Drawing.Size(527, 297);
            this.hTabControl1.Speed = 100;
            this.hTabControl1.TabIndex = 7;
            this.hTabControl1.TabStyle = HecopUI_Winforms.Enums.TabStyle.Style2;
            this.hTabControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.hTabControl1.TextPadding = new System.Windows.Forms.Padding(0);
            this.hTabControl1.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hTabControl1.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hTabControl1.UnSelectedBorderTabColor = System.Drawing.Color.Silver;
            this.hTabControl1.UnSelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.hTabControl1.UnselectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.hTabControl1.UseAnimation = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.hListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bảo vệ";
            // 
            // hListBox1
            // 
            this.hListBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox1.BorderThickness = 1;
            this.hListBox1.DisableListBoxColor = System.Drawing.Color.LightGray;
            this.hListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hListBox1.HoveredItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(146)))), ((int)(((byte)(241)))));
            this.hListBox1.ItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox1.ListBoxColor = System.Drawing.Color.White;
            this.hListBox1.Location = new System.Drawing.Point(3, 3);
            this.hListBox1.MultiSelect = false;
            this.hListBox1.Name = "hListBox1";
            this.hListBox1.SelectedIndex = -1;
            this.hListBox1.SelectedItem = null;
            this.hListBox1.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox1.ShowScrollBar = false;
            this.hListBox1.Size = new System.Drawing.Size(513, 262);
            this.hListBox1.TabIndex = 0;
            this.hListBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hListBox1.TextHoverColor = System.Drawing.Color.WhiteSmoke;
            this.hListBox1.TextSelectedColor = System.Drawing.Color.White;
            this.hListBox1.ThumbBarColor = System.Drawing.Color.LightGray;
            this.hListBox1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox1.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(146)))), ((int)(((byte)(241)))));
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.hListBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quét";
            // 
            // hListBox2
            // 
            this.hListBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox2.BorderThickness = 1;
            this.hListBox2.DisableListBoxColor = System.Drawing.Color.LightGray;
            this.hListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hListBox2.HoveredItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(146)))), ((int)(((byte)(241)))));
            this.hListBox2.ItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox2.ListBoxColor = System.Drawing.Color.White;
            this.hListBox2.Location = new System.Drawing.Point(3, 3);
            this.hListBox2.MultiSelect = false;
            this.hListBox2.Name = "hListBox2";
            this.hListBox2.SelectedIndex = -1;
            this.hListBox2.SelectedItem = null;
            this.hListBox2.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox2.ShowScrollBar = false;
            this.hListBox2.Size = new System.Drawing.Size(513, 262);
            this.hListBox2.TabIndex = 1;
            this.hListBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hListBox2.TextHoverColor = System.Drawing.Color.WhiteSmoke;
            this.hListBox2.TextSelectedColor = System.Drawing.Color.White;
            this.hListBox2.ThumbBarColor = System.Drawing.Color.LightGray;
            this.hListBox2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox2.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(146)))), ((int)(((byte)(241)))));
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.hListBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(519, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cập nhật";
            // 
            // hListBox3
            // 
            this.hListBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox3.BorderThickness = 1;
            this.hListBox3.DisableListBoxColor = System.Drawing.Color.LightGray;
            this.hListBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hListBox3.HoveredItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(146)))), ((int)(((byte)(241)))));
            this.hListBox3.ItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox3.ListBoxColor = System.Drawing.Color.White;
            this.hListBox3.Location = new System.Drawing.Point(3, 3);
            this.hListBox3.MultiSelect = false;
            this.hListBox3.Name = "hListBox3";
            this.hListBox3.SelectedIndex = -1;
            this.hListBox3.SelectedItem = null;
            this.hListBox3.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox3.ShowScrollBar = false;
            this.hListBox3.Size = new System.Drawing.Size(513, 262);
            this.hListBox3.TabIndex = 1;
            this.hListBox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hListBox3.TextHoverColor = System.Drawing.Color.WhiteSmoke;
            this.hListBox3.TextSelectedColor = System.Drawing.Color.White;
            this.hListBox3.ThumbBarColor = System.Drawing.Color.LightGray;
            this.hListBox3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hListBox3.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(146)))), ((int)(((byte)(241)))));
            // 
            // LogForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Border = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(569, 368);
            this.Controls.Add(this.hTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormControlBox.CloseBoxColor = System.Drawing.Color.White;
            this.FormControlBox.CloseBoxHoverColor = System.Drawing.Color.Red;
            this.FormControlBox.HoverColorShape = HecopUI_Winforms.Controls.HFormControlBox.HoverColorShape.RoundRect;
            this.FormControlBox.IconCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormControlBox.IconCloseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.FormControlBox.IconMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormControlBox.IconMaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FormControlBox.IconMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormControlBox.IconMinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FormControlBox.MaximizeBoxColor = System.Drawing.Color.White;
            this.FormControlBox.MaximizeBoxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormControlBox.MinimizeBoxColor = System.Drawing.Color.White;
            this.FormControlBox.MinimizeBoxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogForm";
            this.ShadowTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhật ký";
            this.hTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HecopUI_Winforms.Controls.HTabControl hTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private HecopUI_Winforms.Controls.HListBox hListBox1;
        private HecopUI_Winforms.Controls.HListBox hListBox2;
        private HecopUI_Winforms.Controls.HListBox hListBox3;
    }
}
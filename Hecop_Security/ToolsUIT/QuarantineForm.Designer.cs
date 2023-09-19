namespace Hecop_Security.ToolsUIT
{
    partial class QuarantineForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuarantineForm));
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CH_File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_VirusName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaMụcĐãChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khôiPhụcMụcĐãChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HButton2 = new HecopUI_Winforms.Controls.HButton();
            this.HButton1 = new HecopUI_Winforms.Controls.HButton();
            this.HButton3 = new HecopUI_Winforms.Controls.HButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng cộng: 0 đối tượng";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_File,
            this.CH_Path,
            this.CH_VirusName,
            this.CH_Size});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 245);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CH_File
            // 
            this.CH_File.Text = "Tệp tin";
            this.CH_File.Width = 105;
            // 
            // CH_Path
            // 
            this.CH_Path.Text = "Đường dẫn";
            this.CH_Path.Width = 158;
            // 
            // CH_VirusName
            // 
            this.CH_VirusName.Text = "Tên virus";
            this.CH_VirusName.Width = 129;
            // 
            // CH_Size
            // 
            this.CH_Size.Text = "Kích cỡ";
            this.CH_Size.Width = 89;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaMụcĐãChọnToolStripMenuItem,
            this.khôiPhụcMụcĐãChọnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 52);
            // 
            // xóaMụcĐãChọnToolStripMenuItem
            // 
            this.xóaMụcĐãChọnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaMụcĐãChọnToolStripMenuItem.Image")));
            this.xóaMụcĐãChọnToolStripMenuItem.Name = "xóaMụcĐãChọnToolStripMenuItem";
            this.xóaMụcĐãChọnToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.xóaMụcĐãChọnToolStripMenuItem.Text = "Xóa mục đã chọn";
            // 
            // khôiPhụcMụcĐãChọnToolStripMenuItem
            // 
            this.khôiPhụcMụcĐãChọnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khôiPhụcMụcĐãChọnToolStripMenuItem.Image")));
            this.khôiPhụcMụcĐãChọnToolStripMenuItem.Name = "khôiPhụcMụcĐãChọnToolStripMenuItem";
            this.khôiPhụcMụcĐãChọnToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.khôiPhụcMụcĐãChọnToolStripMenuItem.Text = "Khôi phục mục đã chọn";
            // 
            // HButton2
            // 
            this.HButton2.AlphaColorAnimated = 180;
            this.HButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        
            this.HButton2.AnimationMode = HecopUI_Winforms.Enums.AnimationMode.ColorTransition;
            this.HButton2.BackColor = System.Drawing.Color.Transparent;
            this.HButton2.BorderColor = System.Drawing.Color.Red;
            this.HButton2.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.HButton2.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.HButton2.BorderThickness = 0;
            this.HButton2.ButtonColor1 = System.Drawing.Color.White;
            this.HButton2.ButtonColor2 = System.Drawing.Color.White;
            this.HButton2.ButtonDownColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HButton2.ButtonDownColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HButton2.ButtonHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HButton2.ButtonHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HButton2.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton2.ClipRegion = false;
            this.HButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HButton2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.HButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HButton2.FocusBorderColor = System.Drawing.Color.White;
            this.HButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.HButton2.Image = ((System.Drawing.Image)(resources.GetObject("HButton2.Image")));
            this.HButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.HButton2.ImageSize = new System.Drawing.Size(20, 20);
           
            this.HButton2.IsAutoSize = false;
            this.HButton2.Location = new System.Drawing.Point(264, 321);
            this.HButton2.Name = "HButton2";
            this.HButton2.PressColorAnimation = System.Drawing.Color.Black;
            this.HButton2.Radius = 0;
            this.HButton2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HButton2.ShadowPadding = new System.Windows.Forms.Padding(1, 1, 2, 3);
            this.HButton2.ShadowRadius = 3;
            this.HButton2.ShapeButtonType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.HButton2.Size = new System.Drawing.Size(161, 35);
            this.HButton2.SupportImageGif = false;
            this.HButton2.TabIndex = 8;
            this.HButton2.Text = "Khôi phục tất cả";
            this.HButton2.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.HButton2.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.HButton2.TextNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.HButton2.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HButton2.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HButton2.TextTrim = System.Drawing.StringTrimming.Character;
            // 
            // HButton1
            // 
            this.HButton1.AlphaColorAnimated = 180;
            this.HButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           
            this.HButton1.AnimationMode = HecopUI_Winforms.Enums.AnimationMode.ColorTransition;
            this.HButton1.BackColor = System.Drawing.Color.Transparent;
            this.HButton1.BorderColor = System.Drawing.Color.Red;
            this.HButton1.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.HButton1.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.HButton1.BorderThickness = 0;
            this.HButton1.ButtonColor1 = System.Drawing.Color.White;
            this.HButton1.ButtonColor2 = System.Drawing.Color.White;
            this.HButton1.ButtonDownColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HButton1.ButtonDownColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HButton1.ButtonHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HButton1.ButtonHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HButton1.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton1.ClipRegion = false;
            this.HButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HButton1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.HButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HButton1.FocusBorderColor = System.Drawing.Color.White;
            this.HButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.HButton1.Image = ((System.Drawing.Image)(resources.GetObject("HButton1.Image")));
            this.HButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.HButton1.ImageSize = new System.Drawing.Size(18, 18);
          
            this.HButton1.IsAutoSize = false;
            this.HButton1.Location = new System.Drawing.Point(431, 321);
            this.HButton1.Name = "HButton1";
            this.HButton1.PressColorAnimation = System.Drawing.Color.Black;
            this.HButton1.Radius = 0;
            this.HButton1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HButton1.ShadowPadding = new System.Windows.Forms.Padding(1, 1, 2, 3);
            this.HButton1.ShadowRadius = 3;
            this.HButton1.ShapeButtonType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.HButton1.Size = new System.Drawing.Size(117, 35);
            this.HButton1.SupportImageGif = false;
            this.HButton1.TabIndex = 7;
            this.HButton1.Text = "Xóa tất cả";
            this.HButton1.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.HButton1.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.HButton1.TextNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.HButton1.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HButton1.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HButton1.TextTrim = System.Drawing.StringTrimming.Character;
            // 
            // HButton3
            // 
            this.HButton3.AlphaColorAnimated = 180;
            this.HButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           
            this.HButton3.AnimationMode = HecopUI_Winforms.Enums.AnimationMode.ColorTransition;
            this.HButton3.BackColor = System.Drawing.Color.Transparent;
            this.HButton3.BorderColor = System.Drawing.Color.Red;
            this.HButton3.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.HButton3.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.HButton3.BorderThickness = 0;
            this.HButton3.ButtonColor1 = System.Drawing.Color.White;
            this.HButton3.ButtonColor2 = System.Drawing.Color.White;
            this.HButton3.ButtonDownColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HButton3.ButtonDownColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HButton3.ButtonHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HButton3.ButtonHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HButton3.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton3.ClipRegion = false;
            this.HButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HButton3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.HButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HButton3.FocusBorderColor = System.Drawing.Color.White;
            this.HButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.HButton3.Image = ((System.Drawing.Image)(resources.GetObject("HButton3.Image")));
            this.HButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton3.ImagePadding = new System.Windows.Forms.Padding(0);
            this.HButton3.ImageSize = new System.Drawing.Size(20, 20);
           
            this.HButton3.IsAutoSize = false;
            this.HButton3.Location = new System.Drawing.Point(20, 321);
            this.HButton3.Name = "HButton3";
            this.HButton3.PressColorAnimation = System.Drawing.Color.Black;
            this.HButton3.Radius = 0;
            this.HButton3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HButton3.ShadowPadding = new System.Windows.Forms.Padding(1, 1, 2, 3);
            this.HButton3.ShadowRadius = 3;
            this.HButton3.ShapeButtonType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.HButton3.Size = new System.Drawing.Size(92, 35);
            this.HButton3.SupportImageGif = false;
            this.HButton3.TabIndex = 9;
            this.HButton3.Text = "Thêm";
            this.HButton3.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.HButton3.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.HButton3.TextNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.HButton3.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HButton3.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HButton3.TextTrim = System.Drawing.StringTrimming.Character;
            // 
            // QuarantineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Border = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(569, 368);
            this.Controls.Add(this.HButton3);
            this.Controls.Add(this.HButton2);
            this.Controls.Add(this.HButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
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
            this.Name = "QuarantineForm";
            this.Resizable = false;
            this.ShadowTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cách ly";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CH_File;
        private System.Windows.Forms.ColumnHeader CH_Path;
        private System.Windows.Forms.ColumnHeader CH_VirusName;
        private System.Windows.Forms.ColumnHeader CH_Size;
        private HecopUI_Winforms.Controls.HButton HButton2;
        private HecopUI_Winforms.Controls.HButton HButton1;
        private HecopUI_Winforms.Controls.HButton HButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaMụcĐãChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khôiPhụcMụcĐãChọnToolStripMenuItem;
    }
}
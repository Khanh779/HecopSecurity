namespace Hecop_Security.ScanMode
{
    partial class QuickScanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickScanForm));
            this.hCircularProgressBar1 = new HecopUI_Winforms.Controls.HCircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hLabel1 = new HecopUI_Winforms.Controls.HLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.HButton3 = new HecopUI_Winforms.Controls.HButton();
            this.HButton4 = new HecopUI_Winforms.Controls.HButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hImage1 = new HecopUI_Winforms.Controls.HImage();
            this.SuspendLayout();
            // 
            // hCircularProgressBar1
            // 
            this.hCircularProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hCircularProgressBar1.AnimationMode = HecopUI_Winforms.Controls.HCircularProgressBar.AnimationType.None;
            this.hCircularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.hCircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hCircularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.hCircularProgressBar1.InnerMargin = 2;
            this.hCircularProgressBar1.InnerWidth = -1;
            this.hCircularProgressBar1.Interval = 30;
            this.hCircularProgressBar1.Location = new System.Drawing.Point(175, 130);
            this.hCircularProgressBar1.Maximum = 100;
            this.hCircularProgressBar1.Minimum = 0;
            this.hCircularProgressBar1.Name = "hCircularProgressBar1";
            this.hCircularProgressBar1.OuterColor = System.Drawing.Color.Silver;
            this.hCircularProgressBar1.OuterMargin = -10;
            this.hCircularProgressBar1.OuterWidth = 10;
            this.hCircularProgressBar1.ProgressBarValue = 0;
            this.hCircularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hCircularProgressBar1.ProgressTextMode = HecopUI_Winforms.Controls.HCircularProgressBar.TextMode.None;
            this.hCircularProgressBar1.ProgressWidth = 5;
            this.hCircularProgressBar1.Size = new System.Drawing.Size(92, 92);
            this.hCircularProgressBar1.TabIndex = 1;
            this.hCircularProgressBar1.Text = "hCircularProgressBar1";
            this.hCircularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.hCircularProgressBar1.TextRenderHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.hCircularProgressBar1.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tệp đã quét:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tệp bị nhiễm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(261, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoEllipsis = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(261, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hLabel1
            // 
            this.hLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hLabel1.BackColor = System.Drawing.Color.Transparent;
            this.hLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.hLabel1.Location = new System.Drawing.Point(90, 230);
            this.hLabel1.Name = "hLabel1";
            this.hLabel1.Size = new System.Drawing.Size(265, 38);
            this.hLabel1.TabIndex = 7;
            this.hLabel1.Text = "hLabel1";
            this.hLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hLabel1.TextTrim = System.Drawing.StringTrimming.EllipsisPath;
            this.hLabel1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(261, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sẵn sàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.HButton3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.HButton3.Image = ((System.Drawing.Image)(resources.GetObject("HButton3.Image")));
            this.HButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton3.ImagePadding = new System.Windows.Forms.Padding(0);
            this.HButton3.ImageSize = new System.Drawing.Size(20, 20);
            
            this.HButton3.IsAutoSize = false;
            this.HButton3.Location = new System.Drawing.Point(189, 277);
            this.HButton3.Name = "HButton3";
            this.HButton3.PressColorAnimation = System.Drawing.Color.Black;
            this.HButton3.Radius = 0;
            this.HButton3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HButton3.ShadowPadding = new System.Windows.Forms.Padding(1, 1, 2, 3);
            this.HButton3.ShadowRadius = 3;
            this.HButton3.ShapeButtonType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.HButton3.Size = new System.Drawing.Size(103, 35);
            this.HButton3.SupportImageGif = false;
            this.HButton3.TabIndex = 13;
            this.HButton3.Text = "Hủy";
            this.HButton3.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.HButton3.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.HButton3.TextNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.HButton3.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HButton3.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HButton3.TextTrim = System.Drawing.StringTrimming.Character;
            // 
            // HButton4
            // 
            this.HButton4.AlphaColorAnimated = 180;
            this.HButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           
            this.HButton4.AnimationMode = HecopUI_Winforms.Enums.AnimationMode.ColorTransition;
            this.HButton4.AnimationMode = HecopUI_Winforms.Enums.AnimationMode.ColorTransition;
            this.HButton4.BackColor = System.Drawing.Color.Transparent;
            this.HButton4.BorderColor = System.Drawing.Color.Red;
            this.HButton4.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.HButton4.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.HButton4.BorderThickness = 0;
            this.HButton4.ButtonColor1 = System.Drawing.Color.White;
            this.HButton4.ButtonColor2 = System.Drawing.Color.White;
            this.HButton4.ButtonDownColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HButton4.ButtonDownColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HButton4.ButtonHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HButton4.ButtonHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HButton4.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton4.ClipRegion = false;
            this.HButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HButton4.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.HButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HButton4.FocusBorderColor = System.Drawing.Color.White;
            this.HButton4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.HButton4.Image = ((System.Drawing.Image)(resources.GetObject("HButton4.Image")));
            this.HButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HButton4.ImagePadding = new System.Windows.Forms.Padding(0);
            this.HButton4.ImageSize = new System.Drawing.Size(18, 18);
         
            this.HButton4.IsAutoSize = false;
            this.HButton4.Location = new System.Drawing.Point(298, 277);
            this.HButton4.Name = "HButton4";
            this.HButton4.PressColorAnimation = System.Drawing.Color.Black;
            this.HButton4.Radius = 0;
            this.HButton4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HButton4.ShadowPadding = new System.Windows.Forms.Padding(1, 1, 2, 3);
            this.HButton4.ShadowRadius = 3;
            this.HButton4.ShapeButtonType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.HButton4.ShapeButtonType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.HButton4.Size = new System.Drawing.Size(103, 35);
            this.HButton4.SupportImageGif = false;
            this.HButton4.TabIndex = 12;
            this.HButton4.Text = "Bắt đầu";
            this.HButton4.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.HButton4.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.HButton4.TextNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.HButton4.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HButton4.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HButton4.TextTrim = System.Drawing.StringTrimming.Character;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // hImage1
            // 
            this.hImage1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hImage1.HShapeType = HecopUI_Winforms.Enums.ShapeType.Rectangle;
            this.hImage1.Image = ((System.Drawing.Image)(resources.GetObject("hImage1.Image")));
            this.hImage1.ImageSize = new System.Drawing.Size(60, 60);
            this.hImage1.Location = new System.Drawing.Point(68, 130);
            this.hImage1.Name = "hImage1";
            this.hImage1.SetImageSizeMode = HecopUI_Winforms.Controls.HImage.ImageSizeMode.Custom;
            this.hImage1.Size = new System.Drawing.Size(92, 92);
            this.hImage1.TabIndex = 14;
            this.hImage1.Text = "hImage1";
            // 
            // QuickScanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(136)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(426, 327);
            this.Controls.Add(this.hImage1);
            this.Controls.Add(this.HButton3);
            this.Controls.Add(this.HButton4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hCircularProgressBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormControlBox.CloseBoxColor = System.Drawing.Color.White;
            this.FormControlBox.CloseBoxHoverColor = System.Drawing.Color.Red;
            this.FormControlBox.HoverColorShape = HecopUI_Winforms.Controls.HFormControlBox.HoverColorShape.RoundRect;
            this.FormControlBox.IconCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormControlBox.IconCloseHoverColor = System.Drawing.Color.White;
            this.FormControlBox.IconMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormControlBox.IconMaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FormControlBox.IconMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormControlBox.IconMinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FormControlBox.MaximizeBoxColor = System.Drawing.Color.White;
            this.FormControlBox.MaximizeBoxHoverColor = System.Drawing.Color.WhiteSmoke;
            this.FormControlBox.MinimizeBoxColor = System.Drawing.Color.White;
            this.FormControlBox.MinimizeBoxHoverColor = System.Drawing.Color.WhiteSmoke;
            this.MaximizeBox = false;
            this.Name = "QuickScanForm";
            this.Resizable = false;
            this.ShadowTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quét nhanh";
            this.ResumeLayout(false);

        }

        #endregion
        private HecopUI_Winforms.Controls.HCircularProgressBar hCircularProgressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private HecopUI_Winforms.Controls.HLabel hLabel1;
        private System.Windows.Forms.Label label4;
        private HecopUI_Winforms.Controls.HButton HButton3;
        private HecopUI_Winforms.Controls.HButton HButton4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HecopUI_Winforms.Controls.HImage hImage1;
    }
}
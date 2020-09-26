namespace StringSearch_Project
{
    partial class frm_search
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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtPathName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.numGram = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecoded = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblProgress = new System.Windows.Forms.Label();
            this.radioClass = new System.Windows.Forms.RadioButton();
            this.radioMeta = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // txtPathName
            // 
            this.txtPathName.Location = new System.Drawing.Point(158, 227);
            this.txtPathName.Name = "txtPathName";
            this.txtPathName.Size = new System.Drawing.Size(414, 20);
            this.txtPathName.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "أدخل ملف للفحص\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstResults.BackColor = System.Drawing.SystemColors.Window;
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(12, 301);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(560, 264);
            this.lstResults.TabIndex = 17;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // numGram
            // 
            this.numGram.Location = new System.Drawing.Point(99, 256);
            this.numGram.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numGram.Name = "numGram";
            this.numGram.Size = new System.Drawing.Size(120, 20);
            this.numGram.TabIndex = 22;
            this.numGram.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "BLockLength";
            // 
            // txtDecoded
            // 
            this.txtDecoded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecoded.Location = new System.Drawing.Point(578, 12);
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.Size = new System.Drawing.Size(355, 553);
            this.txtDecoded.TabIndex = 23;
            this.txtDecoded.Text = "";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(283, 282);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 25;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioClass
            // 
            this.radioClass.AutoSize = true;
            this.radioClass.Location = new System.Drawing.Point(271, 259);
            this.radioClass.Name = "radioClass";
            this.radioClass.Size = new System.Drawing.Size(87, 17);
            this.radioClass.TabIndex = 26;
            this.radioClass.Text = "بحث في الكل";
            this.radioClass.UseVisualStyleBackColor = true;
            // 
            // radioMeta
            // 
            this.radioMeta.AutoSize = true;
            this.radioMeta.Checked = true;
            this.radioMeta.Location = new System.Drawing.Point(410, 259);
            this.radioMeta.Name = "radioMeta";
            this.radioMeta.Size = new System.Drawing.Size(161, 17);
            this.radioMeta.TabIndex = 27;
            this.radioMeta.TabStop = true;
            this.radioMeta.Text = "بحث حسب الكلمات المفتاحية";
            this.radioMeta.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StringSearch_Project.Properties.Resources.geosearch_header;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(240, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "عرض التشابه في الملف المدخل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioMeta);
            this.Controls.Add(this.radioClass);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecoded);
            this.Controls.Add(this.numGram);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtPathName);
            this.Name = "frm_search";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "البحث عن التشابه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txtPathName;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.NumericUpDown numGram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDecoded;
        public static System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.RadioButton radioClass;
        private System.Windows.Forms.RadioButton radioMeta;
        private System.Windows.Forms.Button button1;
    }
}
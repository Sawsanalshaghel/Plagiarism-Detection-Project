namespace StringSearch_Project
{
    partial class frm_main
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stroBtnPapers = new System.Windows.Forms.ToolStripButton();
            this.stroBtnCompare = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stroBtnPapers,
            this.toolStripButton2,
            this.stroBtnCompare});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(768, 70);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // stroBtnPapers
            // 
            this.stroBtnPapers.Image = global::StringSearch_Project.Properties.Resources.Books1;
            this.stroBtnPapers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stroBtnPapers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stroBtnPapers.Name = "stroBtnPapers";
            this.stroBtnPapers.Size = new System.Drawing.Size(58, 67);
            this.stroBtnPapers.Text = "الأطروحات";
            this.stroBtnPapers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stroBtnPapers.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // stroBtnCompare
            // 
            this.stroBtnCompare.Image = global::StringSearch_Project.Properties.Resources.Hat_and_Magic_Wand;
            this.stroBtnCompare.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stroBtnCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stroBtnCompare.Name = "stroBtnCompare";
            this.stroBtnCompare.Size = new System.Drawing.Size(52, 67);
            this.stroBtnCompare.Text = "إعدادات";
            this.stroBtnCompare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stroBtnCompare.Click += new System.EventHandler(this.stroBtnCompare_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::StringSearch_Project.Properties.Resources.Nes_Ing1;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(97, 67);
            this.toolStripButton2.Text = "كشف نسبة التشابه";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 350);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الواجهة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.Shown += new System.EventHandler(this.frm_main_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stroBtnPapers;
        private System.Windows.Forms.ToolStripButton stroBtnCompare;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
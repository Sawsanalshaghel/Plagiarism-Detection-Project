namespace StringSearch_Project
{
    partial class frm_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPaperName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPathName = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtStudents = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paper_notes_txtBox = new System.Windows.Forms.TextBox();
            this.listStudents = new System.Windows.Forms.ListBox();
            this.listTeachers = new System.Windows.Forms.ListBox();
            this.txtTeachers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان الاطروحة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 68);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الطلاب";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPaperName
            // 
            this.txtPaperName.Location = new System.Drawing.Point(126, 39);
            this.txtPaperName.Name = "txtPaperName";
            this.txtPaperName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPaperName.Size = new System.Drawing.Size(356, 20);
            this.txtPaperName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 16);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ادخل ملف الاطروحة";
            // 
            // txtPathName
            // 
            this.txtPathName.Location = new System.Drawing.Point(126, 13);
            this.txtPathName.Name = "txtPathName";
            this.txtPathName.Size = new System.Drawing.Size(275, 20);
            this.txtPathName.TabIndex = 7;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(407, 11);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 8;
            this.BrowseBtn.Text = "استعراض...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 273);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(470, 158);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtStudents
            // 
            this.txtStudents.Location = new System.Drawing.Point(362, 65);
            this.txtStudents.Name = "txtStudents";
            this.txtStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudents.Size = new System.Drawing.Size(120, 20);
            this.txtStudents.TabIndex = 17;
            this.txtStudents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudents_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ملاحظات";
            // 
            // paper_notes_txtBox
            // 
            this.paper_notes_txtBox.Location = new System.Drawing.Point(126, 192);
            this.paper_notes_txtBox.Multiline = true;
            this.paper_notes_txtBox.Name = "paper_notes_txtBox";
            this.paper_notes_txtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paper_notes_txtBox.Size = new System.Drawing.Size(356, 20);
            this.paper_notes_txtBox.TabIndex = 21;
            // 
            // listStudents
            // 
            this.listStudents.FormattingEnabled = true;
            this.listStudents.Location = new System.Drawing.Point(362, 91);
            this.listStudents.Name = "listStudents";
            this.listStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listStudents.Size = new System.Drawing.Size(120, 95);
            this.listStudents.TabIndex = 25;
            // 
            // listTeachers
            // 
            this.listTeachers.FormattingEnabled = true;
            this.listTeachers.Location = new System.Drawing.Point(126, 91);
            this.listTeachers.Name = "listTeachers";
            this.listTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listTeachers.Size = new System.Drawing.Size(120, 95);
            this.listTeachers.TabIndex = 27;
            // 
            // txtTeachers
            // 
            this.txtTeachers.Location = new System.Drawing.Point(126, 65);
            this.txtTeachers.Name = "txtTeachers";
            this.txtTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeachers.Size = new System.Drawing.Size(120, 20);
            this.txtTeachers.TabIndex = 26;
            this.txtTeachers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTeachers_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "المشرفين";
            // 
            // txtFileContent
            // 
            this.txtFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileContent.Location = new System.Drawing.Point(501, 39);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ReadOnly = true;
            this.txtFileContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFileContent.Size = new System.Drawing.Size(482, 456);
            this.txtFileContent.TabIndex = 29;
            this.txtFileContent.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StringSearch_Project.Properties.Resources.Books2;
            this.pictureBox1.Location = new System.Drawing.Point(65, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 61);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // DelBtn
            // 
            this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelBtn.Image = ((System.Drawing.Image)(resources.GetObject("DelBtn.Image")));
            this.DelBtn.Location = new System.Drawing.Point(93, 441);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 59);
            this.DelBtn.TabIndex = 16;
            this.DelBtn.Text = "الغاء الأمر";
            this.DelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(12, 441);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 59);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "موافق";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(498, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 489);
            this.label3.TabIndex = 31;
            this.label3.Text = "Preview";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(356, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "التاريخ\r\n";
            // 
            // frm_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 507);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listTeachers);
            this.Controls.Add(this.txtTeachers);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.paper_notes_txtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudents);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.txtPathName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPaperName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "frm_add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة معلومات أطروحة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPaperName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPathName;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.TextBox txtStudents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox paper_notes_txtBox;
        private System.Windows.Forms.ListBox listStudents;
        private System.Windows.Forms.ListBox listTeachers;
        private System.Windows.Forms.TextBox txtTeachers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
    }
}


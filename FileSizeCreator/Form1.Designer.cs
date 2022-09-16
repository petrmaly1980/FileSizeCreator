namespace FileSizeCreator
{
    partial class Form1
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
            this.buttonCreateSingle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.txtBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateMultipleFiles = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilesCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSplitSize = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCreatedFiles = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateSingle
            // 
            this.buttonCreateSingle.Location = new System.Drawing.Point(11, 72);
            this.buttonCreateSingle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateSingle.Name = "buttonCreateSingle";
            this.buttonCreateSingle.Size = new System.Drawing.Size(194, 24);
            this.buttonCreateSingle.TabIndex = 2;
            this.buttonCreateSingle.Text = "Create Single";
            this.buttonCreateSingle.UseVisualStyleBackColor = true;
            this.buttonCreateSingle.Click += new System.EventHandler(this.buttonCreateSingle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOpen);
            this.groupBox1.Controls.Add(this.txtBoxFileName);
            this.groupBox1.Controls.Add(this.txtBoxOutputFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single File";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(325, 17);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Location = new System.Drawing.Point(118, 45);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(195, 20);
            this.txtBoxFileName.TabIndex = 1;
            this.txtBoxFileName.Text = "file.dat";
            // 
            // txtBoxOutputFolder
            // 
            this.txtBoxOutputFolder.Location = new System.Drawing.Point(118, 19);
            this.txtBoxOutputFolder.Name = "txtBoxOutputFolder";
            this.txtBoxOutputFolder.Size = new System.Drawing.Size(195, 20);
            this.txtBoxOutputFolder.TabIndex = 0;
            this.txtBoxOutputFolder.Text = "C:\\temp\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Folder:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GB",
            "MB",
            "B"});
            this.comboBox1.Location = new System.Drawing.Point(57, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(57, 20);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(149, 20);
            this.txtFileSize.TabIndex = 0;
            this.txtFileSize.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "File Size:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateMultipleFiles);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFilesCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxSplitSize);
            this.groupBox2.Location = new System.Drawing.Point(227, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 101);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multiple Files";
            // 
            // btnCreateMultipleFiles
            // 
            this.btnCreateMultipleFiles.Location = new System.Drawing.Point(5, 73);
            this.btnCreateMultipleFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateMultipleFiles.Name = "btnCreateMultipleFiles";
            this.btnCreateMultipleFiles.Size = new System.Drawing.Size(209, 24);
            this.btnCreateMultipleFiles.TabIndex = 2;
            this.btnCreateMultipleFiles.Text = "Create Multiple Files";
            this.btnCreateMultipleFiles.UseVisualStyleBackColor = true;
            this.btnCreateMultipleFiles.Click += new System.EventHandler(this.btnCreateMultipleFiles_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "MB";
            // 
            // txtFilesCount
            // 
            this.txtFilesCount.Location = new System.Drawing.Point(118, 20);
            this.txtFilesCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilesCount.Name = "txtFilesCount";
            this.txtFilesCount.Size = new System.Drawing.Size(76, 20);
            this.txtFilesCount.TabIndex = 0;
            this.txtFilesCount.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Files count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Split size:";
            // 
            // txtBoxSplitSize
            // 
            this.txtBoxSplitSize.Location = new System.Drawing.Point(118, 44);
            this.txtBoxSplitSize.Name = "txtBoxSplitSize";
            this.txtBoxSplitSize.Size = new System.Drawing.Size(76, 20);
            this.txtBoxSplitSize.TabIndex = 1;
            this.txtBoxSplitSize.Text = "100";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.buttonCreateSingle);
            this.groupBox3.Controls.Add(this.txtFileSize);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 114);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(210, 101);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Single File";
            // 
            // lblCreatedFiles
            // 
            this.lblCreatedFiles.AutoSize = true;
            this.lblCreatedFiles.Location = new System.Drawing.Point(390, 218);
            this.lblCreatedFiles.Name = "lblCreatedFiles";
            this.lblCreatedFiles.Size = new System.Drawing.Size(13, 13);
            this.lblCreatedFiles.TabIndex = 6;
            this.lblCreatedFiles.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Created Files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 237);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCreatedFiles);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "File Size Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateSingle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.TextBox txtBoxOutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSplitSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateMultipleFiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCreatedFiles;
        private System.Windows.Forms.Label label7;
    }
}


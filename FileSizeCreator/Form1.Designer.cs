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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.txtBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonMultipleFiles = new System.Windows.Forms.RadioButton();
            this.radioButtonSingleFile = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 279);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(440, 24);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtFileSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonOpen);
            this.groupBox1.Controls.Add(this.txtBoxFileName);
            this.groupBox1.Controls.Add(this.txtBoxOutputFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GB",
            "MB",
            "B"});
            this.comboBox1.Location = new System.Drawing.Point(319, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(118, 71);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(195, 20);
            this.txtFileSize.TabIndex = 6;
            this.txtFileSize.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "File Size:";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(325, 17);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Location = new System.Drawing.Point(118, 45);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(195, 20);
            this.txtBoxFileName.TabIndex = 3;
            this.txtBoxFileName.Text = "data.dat";
            // 
            // txtBoxOutputFolder
            // 
            this.txtBoxOutputFolder.Location = new System.Drawing.Point(118, 19);
            this.txtBoxOutputFolder.Name = "txtBoxOutputFolder";
            this.txtBoxOutputFolder.Size = new System.Drawing.Size(195, 20);
            this.txtBoxOutputFolder.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.radioButtonMultipleFiles);
            this.groupBox2.Controls.Add(this.radioButtonSingleFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // radioButtonMultipleFiles
            // 
            this.radioButtonMultipleFiles.AutoSize = true;
            this.radioButtonMultipleFiles.Location = new System.Drawing.Point(248, 19);
            this.radioButtonMultipleFiles.Name = "radioButtonMultipleFiles";
            this.radioButtonMultipleFiles.Size = new System.Drawing.Size(152, 17);
            this.radioButtonMultipleFiles.TabIndex = 4;
            this.radioButtonMultipleFiles.TabStop = true;
            this.radioButtonMultipleFiles.Text = "Multiple files with Timestam";
            this.radioButtonMultipleFiles.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingleFile
            // 
            this.radioButtonSingleFile.AutoSize = true;
            this.radioButtonSingleFile.Location = new System.Drawing.Point(104, 19);
            this.radioButtonSingleFile.Name = "radioButtonSingleFile";
            this.radioButtonSingleFile.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSingleFile.TabIndex = 2;
            this.radioButtonSingleFile.TabStop = true;
            this.radioButtonSingleFile.Text = "Single File";
            this.radioButtonSingleFile.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Split size:(MB)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 316);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreate);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.TextBox txtBoxOutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSingleFile;
        private System.Windows.Forms.RadioButton radioButtonMultipleFiles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}


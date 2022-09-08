using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSizeCreator
{
    public partial class Form1 : Form
    {
        private string _size;

        public Form1()
        {
            InitializeComponent();
            BackgroundWorker worker = new BackgroundWorker();
            comboBox1.SelectedIndex = 0;
        }
        
        public static void CreateRandomFile(string filePath, int sizeInMb)
        {
            // Note: block size must be a factor of 1MB to avoid rounding errors
            const int blockSize = 1024 * 8;
            const int blocksPerMb = (1024 * 1024) / blockSize;

            byte[] data = new byte[blockSize];

            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                using (FileStream stream = File.OpenWrite(filePath))
                {
                    for (int i = 0; i < sizeInMb * blocksPerMb; i++)
                    {
                        crypto.GetBytes(data);
                        stream.Write(data, 0, data.Length);
                    }
                }
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string timeStamp = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'.'mm'.'ss");
            //FileStream fs = new FileStream(txtBoxOutputFolder.Text+ timeStamp + txtBoxFileName.Text, FileMode.CreateNew);

            _size = comboBox1.Text;
            switch (_size)
            {
                case "GB":
                    MessageBox.Show("Output file: " + txtBoxOutputFolder.Text + timeStamp + txtBoxFileName.Text);
                    MessageBox.Show("Selected combobox: " + comboBox1.Text);
                    MessageBox.Show("Ready to create file size: " + txtFileSize.Text + "GB");
                    CreateRandomFile(txtBoxOutputFolder.Text + timeStamp + txtBoxFileName.Text, Convert.ToInt32(txtFileSize.Text)*1000);
                    MessageBox.Show("Finish!");
                    break;
                case "MB":
                    MessageBox.Show("Output file: " + txtBoxOutputFolder.Text + timeStamp + txtBoxFileName.Text);
                    MessageBox.Show(txtBoxOutputFolder.Text + txtBoxFileName.Text);
                    MessageBox.Show("Selected combobox: " + comboBox1.Text);
                    MessageBox.Show("Ready to create file size: " + txtFileSize.Text + "MB");
                    CreateRandomFile(txtBoxOutputFolder.Text + timeStamp + txtBoxFileName.Text, Convert.ToInt32(txtFileSize.Text));
                    MessageBox.Show("Finish!");
                    break;
                case "B":
                    MessageBox.Show("Output file: " + txtBoxOutputFolder.Text + timeStamp + txtBoxFileName.Text);
                    MessageBox.Show(txtBoxOutputFolder.Text + txtBoxFileName.Text);
                    MessageBox.Show("Selected combobox: " + comboBox1.Text);
                    MessageBox.Show("Ready to create file size: " + txtFileSize.Text + "Byte");
                    CreateRandomFile(txtBoxOutputFolder.Text + timeStamp + txtBoxFileName.Text, Convert.ToInt32(txtFileSize.Text));
                    MessageBox.Show("Finish!");
                    break;
            }
            //fs.Seek(2048L * 1024 * 1024, SeekOrigin.Begin);
            //fs.WriteByte(0);
            //fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateRandomFile(@"d:\huge_dummy_file2.dat", 1024);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"d:\huge_dummy_file1.dat", FileMode.CreateNew);
            fs.Seek(2048L * 1024 + 1024, SeekOrigin.Current);
        }
        public void ChooseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = "C:\\";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtBoxOutputFolder.Text = fbd.SelectedPath + "\\";
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
    }
}

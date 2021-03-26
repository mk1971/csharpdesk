using System;
using System.IO;
using System.Windows.Forms;

namespace FileClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\testFile.txt"))
            {
                //shows message if testFile exist
                MessageBox.Show("File 'testFile' Exist ");
            }
            else
            {
                //create the file testFile.txt
                File.Create("C:\\testFile.txt");
                MessageBox.Show("File 'testFile' created ");
            }
        }
    }
}

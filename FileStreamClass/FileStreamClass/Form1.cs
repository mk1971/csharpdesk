using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileStreamClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.FileStream wFile;
                byte[] byteData = null;
                byteData = Encoding.ASCII.GetBytes("FileStream Test");
                wFile = new FileStream("c:\\streamtest.txt", FileMode.Append);
                wFile.Write(byteData, 0, byteData.Length);
                wFile.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace Textreader02
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
                string line = null;
                System.IO.TextReader readFile = new StreamReader("C:\\net-informations.txt");
                line = readFile.ReadToEnd();
                MessageBox.Show(line);
                readFile.Close();
                readFile = null;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

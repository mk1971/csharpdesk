using System;
using System.IO;
using System.Windows.Forms;

namespace TextreaderClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string line = null;
                System.IO.TextReader readFile = new StreamReader("C:\\csharp.net-informations.txt");
                while (true)
                {
                    line = readFile.ReadLine();
                    if (line != null)
                    {
                        MessageBox.Show(line);
                    }
                }
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

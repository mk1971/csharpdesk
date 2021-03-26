using System;
using System.IO;
using System.Windows.Forms;

namespace Textwriter
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
                System.IO.TextWriter writeFile = new StreamWriter("c:\\textwriter.txt");
                writeFile.WriteLine("csharp.net-informations.com");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace BinaryReader01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream readStream;
            string msg = null;
            try
            {
                readStream = new FileStream("c:\\csharp.net-informations.dat", FileMode.Open);
                BinaryReader readBinary = new BinaryReader(readStream);
                msg = readBinary.ReadString();
                MessageBox.Show(msg);
                readStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

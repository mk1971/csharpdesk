using System;
using System.IO;
using System.Windows.Forms;

namespace Binarywriter01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream writeStream;
            try
            {
                writeStream = new FileStream("c:\\csharp.net-informations.dat", FileMode.Create);
                BinaryWriter writeBinay = new BinaryWriter(writeStream);
                writeBinay.Write("CSharp.net-informations.com binary writer test");
                writeBinay.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

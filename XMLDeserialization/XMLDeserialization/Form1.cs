using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLDeserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataSet));
            FileStream readStream = new FileStream("serialXML.xml", FileMode.Open);
            ds = (DataSet)xmlSerializer.Deserialize(readStream);
            readStream.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

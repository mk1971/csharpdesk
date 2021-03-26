using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace FilterXMLFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);
            dv = new DataView(ds.Tables[0], "Product_price > = 3000", "Product_Name", DataViewRowState.CurrentRows);
            dv.ToTable().WriteXml("Result.xml");
            MessageBox.Show("Done");
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace Searchxmlfile
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

            dv = new DataView(ds.Tables[0]);
            dv.Sort = "Product_Name";
            int index = dv.Find("Product2");

            if (index == -1)
            {
                MessageBox.Show("Item Not Found");
            }
            else
            {
                MessageBox.Show(dv[index]["Product_Name"].ToString() + " " + dv[index]["Product_Price"].ToString());

            }
        }
    }
}

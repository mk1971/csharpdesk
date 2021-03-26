using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ReadXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //XmlDataDocument xmldoc = new XmlDataDocument();
            //XmlNodeList xmlnode;
            //int i = 0;
            //string str = null;
            //FileStream fs = new FileStream("product.xml", FileMode.Open, FileAccess.Read);
            //xmldoc.Load(fs);
            //xmlnode = xmldoc.GetElementsByTagName("Product");
            //for (i = 0; i <= xmlnode.Count - 1; i++)
            //{
            //    xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
            //    str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
            //    MessageBox.Show(str);
            //}

            //StringBuilder result = new StringBuilder();
            //foreach (XElement level1Element in XElement.Load(@"D:\csharp\ReadXML\product.xml").Elements("Brand"))
            //{
            //    result.AppendLine(level1Element.Attribute("name").Value);
            //    foreach (XElement level2Element in level1Element.Elements("product"))
            //    {
            //        result.AppendLine("  " + level2Element.Attribute("name").Value);
            //    }
            //}
            //MessageBox.Show(result.ToString());

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("d:\\csharp\\ReadXML\\product.xml");
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Product");
            string proID = "", proName = "", price = "";
            foreach (XmlNode node in nodeList)
            {
                proID = node.SelectSingleNode("Product_id").InnerText;
                proName = node.SelectSingleNode("Product_name").InnerText;
                price = node.SelectSingleNode("Product_price").InnerText;
                MessageBox.Show(proID + " " + proName + " " + price);
            }
        }
    }
}

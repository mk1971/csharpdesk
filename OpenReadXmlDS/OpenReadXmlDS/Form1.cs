using System;
using System.Data;
using System.Windows.Forms;

namespace OpenReadXmlDS
{
    public partial class Form1 : Form
    {
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Product_ID", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Product_Name", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("product_Price", Type.GetType("System.Int32")));
            fillRows(1, "product1", 1111);
            fillRows(2, "product2", 2222);
            fillRows(3, "product3", 3333);
            fillRows(4, "product4", 4444);
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "product";
            ds.WriteXml("Product.xml");
            MessageBox.Show("Done");
        }

        private void fillRows(int pID, string pName, int pPrice)
        {
            DataRow dr;
            dr = dt.NewRow();
            dr["Product_ID"] = pID;
            dr["Product_Name"] = pName;
            dr["product_Price"] = pPrice;
            dt.Rows.Add(dr);
        }
    }
}

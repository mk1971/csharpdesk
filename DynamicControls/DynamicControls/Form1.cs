using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicControls
{
    public partial class Form1 : Form
    {
        int cLeft = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewTextBox();
        }

        public System.Windows.Forms.TextBox AddNewTextBox()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            this.Controls.Add(txt);
            txt.Top = cLeft * 25;
            txt.Left = 100;
            txt.Text = "TextBox" + this.cLeft.ToString();
            cLeft = cLeft + 1;
            return txt;
        }
    }
}

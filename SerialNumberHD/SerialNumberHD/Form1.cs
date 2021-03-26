using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Collections;

namespace SerialNumberHD
{
    public partial class frmHDSN : Form
    {
        public frmHDSN()
        {
            InitializeComponent();
        }

        private void btnGetSerialNumber_Click(object sender, System.EventArgs e)
        {
            ArrayList hardDriveDetails = new ArrayList();

            ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach(ManagementObject wmi_HD in moSearcher.Get())
            {
                HardDrive hd = new HardDrive(); // user defined class
                hd.Model = wmi_HD["Model"].ToString();  //model number
                hd.Type = wmi_HD["InterfaceType"].ToString();   //interface type
                hd.SerialNo = wmi_HD["SerialNumber"].ToString();    //serial number
                hardDriveDetails.Add(hd);
                txtModel.Text = hd.Model;
                txtSerialNumber.Text = hd.SerialNo;
                txtType.Text = hd.Type;
            }
        }
    }
}

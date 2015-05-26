using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemVer1.BLL;
using FairManagementSystemVer1.DAL.DAO;

namespace FairManagementSystemVer1
{
    public partial class VisitorEntryUI : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        public VisitorEntryUI()
        {
            InitializeComponent();
        }

        private void VisitorEntryUI_Load(object sender, EventArgs e)
        {
             LoadZoneInCheckBox();
        }

        public void LoadZoneInCheckBox()
        {

            List<Zone> zones = zoneManager.LoadAllZones();
            flowLayoutPanel1.Controls.Clear();

            int serialNumber = 1;
            foreach (Zone zone in zones)
            {
                
                CheckBox myCheckBox = new CheckBox();
                myCheckBox.Name = "zoneTypeCheckBox" + serialNumber;
                myCheckBox.Text = zone.ZName;
                myCheckBox.AutoSize = true;
                myCheckBox.Checked = true;
                flowLayoutPanel1.Controls.Add(myCheckBox);
            }

            
        }

        private void saveVisitorButton_Click(object sender, EventArgs e)
        {

        }
    }
}

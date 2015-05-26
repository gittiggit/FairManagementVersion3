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

namespace FairManagementSystemVer1.UI
{
    public partial class ZoneTypeUI : Form
    {
        ZoneManager zoneManager = new ZoneManager();

        public ZoneTypeUI()
        {
            InitializeComponent();
        }

        private void saveZoneButton_Click(object sender, EventArgs e)
        {
            Zone zone = new Zone();
            zone.ZName = zoneTypeTextBox.Text;
            MessageBox.Show(zoneManager.SaveZone(zone),"Message ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LoadAllZoneInListView();
        }

        private void ZoneTypeUI_Load(object sender, EventArgs e)
        {
              LoadAllZoneInListView();
        }

        public void LoadAllZoneInListView()
        {
            allZoneListView.Items.Clear();
            List<Zone> zones = zoneManager.LoadAllZones();
            int serialNumber = 1;

            foreach (Zone zone in zones)
            {
                ListViewItem listViewItem = new ListViewItem(serialNumber.ToString());
                listViewItem.SubItems.Add(zone.ZName);
                allZoneListView.Items.Add(listViewItem);
                serialNumber++;

            }



        }

       


    }
}

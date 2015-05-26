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
    public partial class ZoneWiseVisitorUI : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        public ZoneWiseVisitorUI()
        {
            InitializeComponent();
        }

        private void ZoneWiseVisitorUI_Load(object sender, EventArgs e)
        {
            LoadZoneWiseVisitorInListView();
        }

        public void LoadZoneWiseVisitorInListView()
        {
            int message = 0;
            
            List<Zone> zones = zoneManager.GetZoneWiseVisitors(out message);
            int serialNumber = 1;
            zoneWiseList.Items.Clear();
            foreach (Zone zone in zones)
            {
                 ListViewItem listViewItem = new ListViewItem(serialNumber.ToString());
                listViewItem.SubItems.Add(zone.ZName);
                listViewItem.SubItems.Add(zone.zoneWiseTotalVisitor.ToString());
                

                zoneWiseList.Items.Add(listViewItem);

            }
            totalVisitortextBox.Text = Convert.ToString(message);
           

        }
    }
}

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
using Microsoft.Office.Interop.Excel;

namespace FairManagementSystemVer1.UI
{
    public partial class ZoneSpecificVisitorUI : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        public ZoneSpecificVisitorUI()
        {
            InitializeComponent();
        }

        private void ZoneSpecificVisitorUI_Load(object sender, EventArgs e)
        {
           
            LoadAllZonesInComboBox();

        }

        private void LoadAllZonesInComboBox()
        {

            List<Zone> zones = zoneManager.LoadAllZones();
           // List<Zone> zones = new List<Zone>();
          //  zoneComboBox.DataSource = zones;
            foreach (Zone zone in zones)
            {
                zoneComboBox.Items.Add(zone.ZName);
            }


           zoneComboBox.DisplayMember = "ZName";
           zoneComboBox.ValueMember = "ID";


        }

        private void showVisitorInSpecificZoneButton_Click(object sender, EventArgs e)
        {
            if (zoneComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(@"Please select a zone .","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                List<Visitor> visitors = zoneManager.GetAllVisitorInSpecificZone(zoneComboBox.SelectedItem.ToString());
                int serialNumber = 1;
                zoneSpecificVisitorListView.Items.Clear();
                foreach (Visitor visitor in visitors)
                {
                    ListViewItem listViewItem = new ListViewItem(serialNumber.ToString());

                    listViewItem.SubItems.Add(visitor.Name.ToString());
                    listViewItem.SubItems.Add(visitor.Email.ToString());
                    listViewItem.SubItems.Add(visitor.ContactNumber.ToString());

                    zoneSpecificVisitorListView.Items.Add(listViewItem);
                    serialNumber++;

                }
            }

            

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in zoneSpecificVisitorListView.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }
        }


    }
}

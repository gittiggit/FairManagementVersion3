using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemVer1.DAL.DAO;

namespace FairManagementSystemVer1.DAL.Gateway
{
    class ZoneGateway
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;

        public ZoneGateway()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            sqlCommand =new SqlCommand();
            sqlCommand.Connection = sqlConnection;
        }

        public List<Zone> LoadAllZones()
        {
            List<Zone> zones = new List<Zone>();
            string query = String.Format("Select * from tbl_Zone");
            sqlCommand.CommandText = query;

            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                
                Zone zone = new Zone();
                zone.ID = Convert.ToInt16(rdr[0]);
                zone.ZName = rdr[1].ToString();

                zones.Add(zone);


            }
            sqlConnection.Close();
                                    

            return zones;
        }

        public bool IsZoneAdded(string zoneName)
        {
            bool isZoneAdded = false;
            string query = String.Format("select * from tbl_Zone where ZoneName='{0}'",zoneName);
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                isZoneAdded = true;
            }
            sqlConnection.Close();
            return isZoneAdded;
        }

        public string SaveZone(Zone zone)
        {
            string query = String.Format("Insert into tbl_Zone values('{0}')", zone.ZName);
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            if (sqlCommand.ExecuteNonQuery()>0)
            {
                sqlConnection.Close();
                return zone.ZName+" "+"zone has been added.";
               
            }
            else
            {
                sqlConnection.Close();
                return zone.ZName + " " + "not added .";
                
            }
            

            
        }

        public List<Zone> GetZoneWiseVisitors(out int zoneWiseTotal )
        {
           // zoneWiseTotal = 0;
            List<Zone> zones = new List<Zone>();
            string query = string.Format(@"select tbl_Zone.ZoneName ,  COUNT(tbl_Visitor.Email)  
                                         from tbl_Zone join tbl_VisitingZone on tbl_Zone.ID = tbl_VisitingZone.ZID
                                         join tbl_Visitor on tbl_VisitingZone.VID = tbl_Visitor.ID
                                         group by tbl_Zone.ZoneName");

            sqlCommand.CommandText = query;
            sqlConnection.Open();

            SqlDataReader rdr = sqlCommand.ExecuteReader();

            while (rdr.Read())
            {
                Zone zone = new Zone();
                zone.ZName = rdr["ZoneName"].ToString();
                zone.zoneWiseTotalVisitor = Convert.ToInt16(rdr[1]);
              //  zoneWiseTotal = Convert.ToInt16(rdr[2]);
                zones.Add(zone);

            }
            sqlConnection.Close();
            zoneWiseTotal = GetTotalVisitor();
            return zones;
        }


        private int GetTotalVisitor()
        {
            string query = string.Format("select COUNT(VID) from tbl_VisitingZone");
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            int totalVisitor = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();

            
            return totalVisitor;
        }

        public List<Visitor> GetAllVisitorInSpecificZone(string zoneType)
        {
            List<Visitor> visitors = new List<Visitor>();
            string query = string.Format(@"select tbl_Visitor.Name , tbl_Visitor.Email , tbl_Visitor.CNumber 
                                           from tbl_Visitor join tbl_VisitingZone  on tbl_Visitor.ID = tbl_VisitingZone.VID 
                                           join tbl_Zone  on tbl_Zone.ID = tbl_VisitingZone.ZID
                                           where tbl_Zone.ZoneName ='{0}'", zoneType);
                                           

            sqlCommand.CommandText = query;

            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();

            while (rdr.Read())
            {
                 Visitor visitor = new Visitor();
                visitor.Name = rdr[0].ToString();
                visitor.Email = rdr[1].ToString();
                visitor.ContactNumber = Convert.ToInt32(rdr[2]);
              visitors.Add(visitor);
            }

            sqlConnection.Close();

            return visitors;

        }

    }
}

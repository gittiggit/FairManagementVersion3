using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemVer1.DAL.DAO;
using FairManagementSystemVer1.DAL.Gateway;

namespace FairManagementSystemVer1.BLL
{
    class ZoneManager
    {
        ZoneGateway zoneGateway = new ZoneGateway();


        public List<Zone> LoadAllZones()
        {
            return zoneGateway.LoadAllZones();
        }

        public string SaveZone(Zone zone)
        {
            if (zoneGateway.IsZoneAdded(zone.ZName))
            {
                return "This zone already exists";
            }
            else
            {
                return zoneGateway.SaveZone(zone); 
            }
           
        }

        public List<Zone> GetZoneWiseVisitors(out int totalZoneVisitor)
        {
           
           int totalVisitor = 0;
           
            List<Zone> zones = zoneGateway.GetZoneWiseVisitors(out totalVisitor);

            totalZoneVisitor = totalVisitor;
            return zones;
        }

        public List<Visitor> GetAllVisitorInSpecificZone(string zoneType)
        {
            return zoneGateway.GetAllVisitorInSpecificZone(zoneType);
        }
    }
}

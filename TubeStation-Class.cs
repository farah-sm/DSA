using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructs
{
    internal class TubeStation
    {
        private int stationID;
        private string name;
        private string tubeLine;
        private string StationAccess;
        private int travelZone;
        private string stationStatus;

        public TubeStation(int stationID, string name, string tubeLine, string stationAccess, int travelZone, string stationStatus)
        {
            this.stationID = stationID;
            this.name = name;
            this.tubeLine = tubeLine;
            StationAccess = stationAccess;
            this.travelZone = travelZone;
            this.stationStatus = stationStatus;
        }   

        public string ToString()
        {
            return (
                " Station: " + stationID + 
                ", Station Name: " + name + 
                ", Tube Line: " + tubeLine + 
                ", Travel Zone: " + travelZone +
                ", Station Status: " + stationStatus + 
                ", Station Access: " + StationAccess 
                );
      
        }
    }
}

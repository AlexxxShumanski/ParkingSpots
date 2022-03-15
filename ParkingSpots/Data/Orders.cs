using System;

namespace ParkingSpots.Data
{
    public class Orders
    {
        public int Id { get; set; }
        public int IdParkSpot { get; set; }
        public string Mark { get; set; }
        public int Registration {get;  set;}
        public int IdClient { get; set; }
        public ParkStop ParkStop { get; set; }
        public int DataParking { get; set; }
        public int DataLeave { get; set; }
        public DateTime OrderOn { get; set; }
    }
}

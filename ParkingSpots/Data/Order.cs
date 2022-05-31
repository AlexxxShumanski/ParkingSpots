using System;

namespace ParkingSpots.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int IdParkSpot { get; set; }
        public ParkSpot ParkSpot { get; set; }
        public string Mark { get; set; }
        public string Registration {get;  set;}
        public string IdUser { get; set; }
        public User User { get; set; }
        public DateTime DataParking { get; set; }
        public DateTime DataLeave { get; set; }
        public DateTime OrderOn { get; set; }
    }
}

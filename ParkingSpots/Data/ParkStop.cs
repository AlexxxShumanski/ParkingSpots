using System;
using System.Collections.Generic;

namespace ParkingSpots.Data
{
    public class ParkStop
    {
        public int Id { get; set; }
        public bool Disabled { get; set; }
        public Category Category { get; set; }
        public string Size { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        public int DateRegstritaion { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ParkStop> ParkSpot { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ParkingSpots.Data
{
    public class ParkSpot
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Size { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        public string Registration { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ParkSpot> ParkSpots { get; set; }
    }
}

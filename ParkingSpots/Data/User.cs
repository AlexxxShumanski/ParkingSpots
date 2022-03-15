using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ParkingSpots.Data
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}

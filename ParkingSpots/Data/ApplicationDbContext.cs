using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSpots.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Client { get; set; }
        public DbSet<ParkStop> ParkStop { get; set; }
        public DbSet<ParkingSpots.Data.Orders> Order { get; set; }
    }
}

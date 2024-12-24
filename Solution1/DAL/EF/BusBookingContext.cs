using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    namespace Catalog.DAL.EF
    {
        public class BusBookingContext : DbContext
        {
          
            public DbSet<Client> Clients { get; set; }
            public DbSet<Schedule> Schedules { get; set; }

            public BusBookingContext(DbContextOptions options) : base(options)
            {
            
            }
        }
     }
}

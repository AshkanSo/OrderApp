using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Personal> tblPersonals { get; set; }
        public DbSet<Product> tblProducts { get; set; }
        public DbSet<Order> tblOrders { get; set; }
        public DbSet<Detail> tblDetails { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }

}

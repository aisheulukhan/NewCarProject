using CarProjectBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProjectBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}

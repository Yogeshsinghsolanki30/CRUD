using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace crud.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityMimarisi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityMimarisi.DataAccess
{
    public class EmployeeDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=10.10.10.50; Database=EmployeeDb;uid=sa;pwd=P67S96L332008%");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

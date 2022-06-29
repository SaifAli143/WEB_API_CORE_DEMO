using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Model;

namespace WEB_API_CORE_DEMO.Entities
{
    public class RepositoriesContext : DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cource> Cources { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCrud.Models;

namespace WebCrud.Data.Models
{
    public class WebCrudContext : DbContext
    {
        public WebCrudContext (DbContextOptions<WebCrudContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}

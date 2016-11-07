using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BumerangHelper.Models.DatabaseModels
{
    public class Context : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Product> Products { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web_SQL.Models
{
    public class Web_SQLContext : DbContext
    {
        public Web_SQLContext (DbContextOptions<Web_SQLContext> options)
            : base(options)
        {
        }

        public DbSet<Web_SQL.Models.Departament> Departament { get; set; }
    }
}

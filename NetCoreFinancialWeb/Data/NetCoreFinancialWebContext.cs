using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreFinancialWeb.Models;

namespace NetCoreFinancialWeb.Data
{
    public class NetCoreFinancialWebContext : DbContext
    {
        public NetCoreFinancialWebContext (DbContextOptions<NetCoreFinancialWebContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreFinancialWeb.Models.Users> Users { get; set; } = default!;
    }
}

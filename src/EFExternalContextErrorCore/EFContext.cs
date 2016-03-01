using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace EFExternalContextErrorCore
{
    public class EFContext : DbContext
    {
        public DbSet<Thing> Things { get; set; }
    }
}

using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// df

namespace DataLayer
{
    public class LoterieDbContext : DbContext
    {
         public LoterieDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Game> Game { get; set; }
        public DbSet<Player> Player { get; set; }
    }
}

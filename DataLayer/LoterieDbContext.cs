using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
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

    // dotnet ef migrations add initial -p .\DataLayer\DataLayer.csproj -s .\loterie_projet_2022\loterie_projet_2022.csproj --context LoterieDbContext --output-dir Migrations
    // dotnet ef database update -p.\DataLayer\DataLayer.csproj -s.\loterie_projet_2022\loterie_projet_2022.csproj --context LoterieDbContext
}

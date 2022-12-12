using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class LoterieDbContext : DbContext
    {
         public LoterieDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
    }

    // dotnet ef migrations add initial -p .\DataLayer\DataLayer.csproj -s .\loterie_projet_2022\loterie_projet_2022.csproj --context LoterieDbContext --output-dir Migrations
    // dotnet ef database update -p.\DataLayer\DataLayer.csproj -s.\loterie_projet_2022\loterie_projet_2022.csproj --context LoterieDbContext
}

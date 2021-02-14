using Chand.Models;
using Microsoft.EntityFrameworkCore;

namespace Chand.Data
{
    public class ChandContext : DbContext
    {
        public DbSet<AccountData> Accounts { get; set; }
        public DbSet<CharacterData> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = $"Server={Config.Database.Host};Database={Config.Database.DbName};Uid={Config.Database.User};Pwd={Config.Database.Pass};";
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }
    }
}

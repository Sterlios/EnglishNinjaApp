using EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMigration
{
    internal class DatabaseCreator : DbContext
    {
        public DatabaseCreator()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlServer(EnglishNinjaConfig.ConnectionString);
    }
}

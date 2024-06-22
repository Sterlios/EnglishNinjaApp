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
        private const string ServerName = "(localdb)\\mssqllocaldb";
        private const string DatabaseName = "EnglishNinja";
        private const string SchemaName = "dbo";
        private const string ConnectionString = $"Server={ServerName};Database={DatabaseName};Trusted_Connection=True;";

        public DatabaseCreator()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}

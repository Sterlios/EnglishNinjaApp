using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public static class EnglishNinjaConfig
    {
        public const string ServerName = "(localdb)\\mssqllocaldb";

        public const string DatabaseName = "EnglishNinja_Dev";
        public const string ConnectionString = $"Server={ServerName};Database={DatabaseName};Trusted_Connection=True;";

        public const string PeopleSchemaName = "People";
        public const string TelegramSchemaName = "Telegram";
        public const string GameSchemaName = "Game";
        public const string EnglishSchemaName = "English";
    }
}

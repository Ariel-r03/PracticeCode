using System.Data.Common;

namespace ToDoListAPI.Connection
{
    public class DbConnection
    {
        private string _connectionString=string.Empty;

        public DbConnection() { 
        var constructor= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _connectionString = constructor.GetSection("ConnectionStrings:conexionmaestra").Value;
        }

        public string SqlString() { return _connectionString; }

    }
}

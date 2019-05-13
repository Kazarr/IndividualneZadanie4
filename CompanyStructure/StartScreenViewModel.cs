using Logic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompanyStructure
{
    public class StartScreenViewModel
    {
        private LogicSystem _logic;

        public LogicSystem Logic { get => _logic; private set => _logic = value; }

        public StartScreenViewModel()
        {
            _logic = new LogicSystem();
        }
        public string GenerateDb()
        {
            return _logic.GenerateDb();
        }
        public bool GenerateTables()
        {
            return _logic.GenerateTables();
        }

        public SqlConnectionStringBuilder GetSqlConnectionStringBuilder()
        {
            return _logic.GetSqlConnectionStringBuilder();
        }

        public SqlConnectionStringBuilder GetSqlConnectionStringBuilder(string initialCatalog)
        {
            return _logic.GetSqlConnectionStringBuilder(initialCatalog);
        }

        public void SaveConnectionString(string connectionString)
        {
            _logic.SaveConnectionString(connectionString);
        }

        public bool HasDatabase()
        {
            return _logic.HasDatabase();
        }
    }
}

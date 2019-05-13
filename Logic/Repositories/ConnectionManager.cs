using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repositories
{
    public class ConnectionManager
    {
        public SqlConnectionStringBuilder GetSqlConnectionStringBuilder(string initialCatalog)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.IntegratedSecurity = true;
            scsb.InitialCatalog = initialCatalog;
            return scsb;
        }

        public void Execute(Action<SqlCommand> executeAction)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            executeAction.Invoke(command);
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine($"Error happend during  Execution \n Error info:{e.Message}\n{e.StackTrace}");
                        //logger 
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error happend during  Connecting \n Error info:{e.Message}\n{e.StackTrace}");
            }
        }
    }
}

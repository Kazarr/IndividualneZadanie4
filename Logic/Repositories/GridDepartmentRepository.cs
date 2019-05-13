using Logic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repositories
{
    public class GridDepartmentRepository:ConnectionManager
    {
        public List<GridCompany> GetCompanies()
        {
            List<GridCompany> ret = new List<GridCompany>();
            Execute((commnad) => 
            {
                commnad.CommandText = @"  select d.name, e.Name, e.Surname from Department as d 
                                          join Employee as e on d.CheifEmployeeId = e.Id
                                          where d.ParentDepartmentId is null";
            using(SqlDataReader reader = commnad.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new GridCompany()
                        {
                            CompanyName = reader.GetString(0),
                            CheifName = reader.GetString(1),
                            CheifSurname = reader.GetString(2)
                        });
                    }
                }
            });
            return ret;
        }
        public List<GridCompany> GetDepartments()
        {
            List<GridCompany> ret = new List<GridCompany>();
            Execute((commnad) =>
            {
                commnad.CommandText = @"  select d.name, e.Name, e.Surname from Department as d 
                                          join Employee as e on d.CheifEmployeeId = e.Id
                                          where d.ParentDepartmentId is not null";
                using (SqlDataReader reader = commnad.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new GridCompany()
                        {
                            CompanyName = reader.GetString(0),
                            CheifName = reader.GetString(1),
                            CheifSurname = reader.GetString(2)
                        });
                    }
                }
            });
            return ret;
        }
    }
}

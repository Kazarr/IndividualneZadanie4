using Logic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                commnad.CommandText = @"  select d.name, e.Name, e.Surname, d.id from Department as d 
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
                            CheifSurname = reader.GetString(2),
                            Id = reader.GetInt32(3)
                        });
                    }
                }
            });
            return ret;
        }

        public GridCompany GetEmployeeDepartment(int? departmentId)
        {
            GridCompany ret = new GridCompany();
            Execute((command) => 
            {
                command.CommandText = @"select d.id, d.Name, e.Name, e.Surname from Department as d
                                      join Employee as e on d.CheifEmployeeId = e.Id
                                      where e.DepartmentId = @departmentId";
                command.Parameters.Add("@departmentId", SqlDbType.Int).Value = departmentId;
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ret.Id = reader.GetInt32(0);
                        ret.CompanyName = reader.GetString(1);
                        ret.CheifName = reader.GetString(2);
                        ret.CheifSurname = reader.GetString(3);
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
                commnad.CommandText = @"  select d.name, e.Name, e.Surname, d.Id from Department as d 
                                          join Employee as e on d.CheifEmployeeId = e.Id
                                          where d.DepartmentTypeId = 4";
                using (SqlDataReader reader = commnad.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new GridCompany()
                        {
                            CompanyName = reader.GetString(0),
                            CheifName = reader.GetString(1),
                            CheifSurname = reader.GetString(2),
                            Id = reader.GetInt32(3)
                        });
                    }
                }
            });
            return ret;
        }

        public List<GridCompany> GetDepartments(int selectedId)
        {
            List<GridCompany> ret = new List<GridCompany>();
            Execute((commnad) =>
            {
                commnad.CommandText = @"  select d.name, e.Name, e.Surname, d.Id from Department as d 
                                          join Employee as e on d.CheifEmployeeId = e.Id
                                          where d.ParentDepartmentId = @selectedId";
                commnad.Parameters.Add("selectedId", SqlDbType.Int).Value = selectedId;
                using (SqlDataReader reader = commnad.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new GridCompany()
                        {
                            CompanyName = reader.GetString(0),
                            CheifName = reader.GetString(1),
                            CheifSurname = reader.GetString(2),
                            Id = reader.GetInt32(3)
                        });
                    }
                }
            });
            return ret;
        }
        public GridCompany GetGridCompany(int selectedId)
        {
            GridCompany ret = new GridCompany();
            Execute((commnad) =>
            {
                commnad.CommandText = @"  select d.name, e.name, e.surname, d.Id from Department as d
                                            join Employee as e on d.CheifEmployeeId = e.Id
                                            where d.Id = @selectedId";
                commnad.Parameters.Add("selectedId", SqlDbType.Int).Value = selectedId;
                using (SqlDataReader reader = commnad.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret = new GridCompany()
                        {
                            CompanyName = reader.GetString(0),
                            CheifName = reader.GetString(1),
                            CheifSurname = reader.GetString(2),
                            Id = reader.GetInt32(3)
                        };
                    }
                }
            });
            return ret;
        }
    }
}

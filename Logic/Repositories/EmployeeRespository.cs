using Logic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repositories
{
    public class EmployeeRespository:ConnectionManager
    {
        public List<Employee> GetEmployees(int selectedId)
        {
            List<Employee> ret = new List<Employee>();
            Execute((command) => 
            {
                command.CommandText = @"select e.id, e.name, e.surname, e.degree, e.phone, e.mail from Employee as e
                                        where e.DepartmentId = @selectedId";
                command.Parameters.Add("@selectedId", SqlDbType.Int).Value = selectedId;
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ret.Add(new Employee()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            SurName = reader.GetString(2),
                            Degree = reader.GetString(3),
                            Phone = reader.GetInt32(4),
                            Mail = reader.GetString(5)
                        });
                    }
                }
            });
            return ret;
        }
    }
}

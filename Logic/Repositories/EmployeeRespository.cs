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
                command.CommandText = @"select * from Employee as e
                                        where e.DepartmentId = @selectedId";
                command.Parameters.Add("@selectedId", SqlDbType.Int).Value = selectedId;
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        ret.Add(new Employee()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            SurName = reader.GetString(2),
                            Degree = reader.GetString(3),
                            Phone = reader.GetInt32(4),
                            Mail = reader.GetString(5),
                            DepartmentId = reader.GetInt32(6)
                        });
                    }
                }
            });
            return ret;
        }
        public bool InsertEmployee(Employee employee)
        {
            bool ret = false;
            Execute((command) => 
            {
                command.CommandText = @"insert into Employee(Name, Surname, Degree, Phone, Mail,DepartmentId)
                                        values(@name, @surname, @degree,@phone,@mail,@departmentId)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = (object)employee.Name ?? DBNull.Value;
                command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = (object)employee.SurName ?? DBNull.Value;
                command.Parameters.Add("@degree", SqlDbType.NVarChar).Value = (object)employee.Degree ?? DBNull.Value;
                command.Parameters.Add("@phone", SqlDbType.Int).Value = (object)employee.Phone ?? DBNull.Value;
                command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = (object)employee.Mail ?? DBNull.Value;
                command.Parameters.Add("@departmentId", SqlDbType.Int).Value = (object)employee.DepartmentId ?? DBNull.Value;
                if (command.ExecuteNonQuery()!= 0)
                {
                    ret = true;
                }
            });
            return ret;
        }

        public void DeleteEmployee(Employee employee)
        {
            Execute((command) =>
            {
                command.CommandText = @"delete from Employee where Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = employee.Id;
                command.ExecuteNonQuery();
            });
        }

        public bool UpdateEmployee(Employee employee)
        {
            bool ret = false;
            Execute((command) =>
            {
                command.CommandText = @"  update Employee
                                          set Name = @name,
                                          Surname = @surname,
                                          Degree = @degree,
                                          Phone = @phone,
                                          Mail = @mail,
                                          DepartmentId = @departmentId
                                          where id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = (object)employee.Id ?? DBNull.Value;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = (object)employee.Name ?? DBNull.Value;
                command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = (object)employee.SurName ?? DBNull.Value;
                command.Parameters.Add("@degree", SqlDbType.NVarChar).Value = (object)employee.Degree ?? DBNull.Value;
                command.Parameters.Add("@phone", SqlDbType.Int).Value = (object)employee.Phone ?? DBNull.Value;
                command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = (object)employee.Mail ?? DBNull.Value;
                command.Parameters.Add("@departmentId", SqlDbType.Int).Value = (object)employee.DepartmentId ?? DBNull.Value;
                if (command.ExecuteNonQuery() != 0)
                {
                    ret = true;
                }
            });
            return ret;
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> ret = new List<Employee>();
            Execute((command) =>
            {
                command.CommandText = @"Select * from Employee";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new Employee()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            SurName = reader.GetString(2),
                            Degree = reader.GetString(3),
                            Phone = reader.GetInt32(4),
                            Mail = reader.GetString(5),
                            DepartmentId = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
                        });
                    }
                }
            });
            return ret;
        }
    }
}

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
    public class DepartmentRepository:ConnectionManager
    {
        public bool InsertDepartment(Department department)
        {
            bool ret = false;
            Execute((command) => 
            {
                command.CommandText = @"insert into department (Name, DepartmentTypeId, ParentDepartmentId, CheifEmployeeId)
                                        values (@name, @departmentTypeId, @parentDepartmentId, @cheifEmployeeId)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = (object)department.Name ?? DBNull.Value;
                command.Parameters.Add("@departmentTypeId", SqlDbType.NVarChar).Value = (object)department.DepartmentType ?? DBNull.Value;
                command.Parameters.Add("@parentDepartmentId", SqlDbType.NVarChar).Value = (object)department.ParentDeparment ?? DBNull.Value;
                command.Parameters.Add("@cheifEmployeeId", SqlDbType.NVarChar).Value = (object)department.CheifEmployeeId ?? DBNull.Value;
                if (command.ExecuteNonQuery() != 0)
                {
                    ret = true;
                }
            });
            return ret;
        }

        public Employee GetCheifEmployee(int? id)
        {
            Employee ret = new Employee();
            Execute((command) => 
            {
                command.CommandText = @"select * from Employee as e join Department as d 
                                        on e.Id = d.CheifEmployeeId
                                        where d.Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ret.Id = reader.GetInt32(0);
                        ret.Name = reader.GetString(1);
                        ret.SurName = reader.GetString(2);
                        ret.Degree = reader.GetString(3);
                        ret.Phone = reader.GetInt32(4);
                        ret.Mail = reader.GetString(5);
                        ret.DepartmentId = reader.GetInt32(6);
                    }
                }

            });
            return ret;
        }

        public List<Department> GetDepartmentByParent(int? departmentId)
        {
            List<Department> ret = new List<Department>();
            Execute((command) => 
            {
                command.CommandText = @"select * from Department where ParentDepartmentId = @departmentId";
                command.Parameters.Add("@departmentId", SqlDbType.Int).Value = departmentId;
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new Department()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            DepartmentType = reader.GetInt32(2),
                            ParentDeparment = reader.GetInt32(3),
                            CheifEmployeeId = reader.GetInt32(4)
                        });
                    }
                }
            });
            return ret;
        }

        public DepartmentType GetDeparmentType(int? id)
        {
            DepartmentType ret = new DepartmentType();
            Execute((command) => 
            {
                command.CommandText = @"select dt.Id, dt.Name from DepartmentType as dt
                                          join Department as d on dt.Id = d.DepartmentTypeId
                                          where d.Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ret.Id = reader.GetInt32(0);
                        ret.Name = reader.GetString(1);
                    }
                }
            });
            return ret;
        }

        public IList<Department> GetDeparmentByType(int? departmentType)
        {
            List<Department> ret = new List<Department>();
            Execute((command) => 
            {
                command.CommandText = @"select * from department where DepartmentTypeId = @departmentType";
                command.Parameters.Add("@departmentType", SqlDbType.Int).Value = departmentType;
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new Department()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            DepartmentType = reader.GetInt32(2),
                            ParentDeparment = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
                            CheifEmployeeId = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4)
                        });
                    }
                }
            });
            return ret;
        }

        public IList<DepartmentType> GetDeparmentTypes()
        {
            List<DepartmentType> ret = new List<DepartmentType>();
            Execute((command) =>
            {
                command.CommandText = @"select * from DepartmentType";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new DepartmentType()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            });
            return ret;
        }

        public Department GetDepartmentById(int departmentId)
        {
            Department ret = new Department();
            Execute((command) => 
            {
                command.CommandText = @"select * from Department where id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = departmentId;
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ret.Id = reader.GetInt32(0);
                        ret.Name = reader.GetString(1);
                        ret.DepartmentType = reader.GetInt32(2);
                        ret.ParentDeparment = reader.GetInt32(3);
                        ret.CheifEmployeeId = reader.GetInt32(4);
                    }
                }
            });
            return ret;
        }

        public bool UpdateDepartment(Department department)
        {
            bool ret = false;
            Execute((command) =>
            {
                command.CommandText = @"  update Department
                                          set Name = @name,
                                          DepartmentTypeId = @departmentTypeId,
                                          ParentDepartmentId = @parentDepartmentId,
                                          CheifEmployeeId = @cheifEmployeeId
                                          where id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = (object)department.Id ?? DBNull.Value;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = (object)department.Name ?? DBNull.Value;
                command.Parameters.Add("@departmentTypeId", SqlDbType.NVarChar).Value = (object)department.DepartmentType ?? DBNull.Value;
                command.Parameters.Add("@parentDepartmentId", SqlDbType.NVarChar).Value = (object)department.ParentDeparment ?? DBNull.Value;
                command.Parameters.Add("@cheifEmployeeId", SqlDbType.NVarChar).Value = (object)department.CheifEmployeeId ?? DBNull.Value;
                if (command.ExecuteNonQuery() != 0)
                {
                    ret = true;
                }
            });
            return ret;
        }
    }
}

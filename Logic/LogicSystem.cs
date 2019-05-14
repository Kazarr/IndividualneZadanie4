using Logic.Model;
using Logic.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class LogicSystem
    {
        private string DB_NAME = "CompanyStructure1";
        private const string INITIAL_CATALOG = "master";
        public string GenerateDb()
        {
            //string ret = "";
            ManagerRepository manager = new ManagerRepository();
            if (manager.GenerateDB())
            {
                DB_NAME = manager.GetDataBaseName();
            }
            return DB_NAME;
        }

        public BindingList<Employee> GetEmployees()
        {
            return new BindingList<Employee>(ManagerRepository.EmployeeRespository.GetAllEmployees());
        }

        public BindingList<DepartmentType> GetDeparmentTypes()
        {
            return new BindingList<DepartmentType>(ManagerRepository.DepartmentRepository.GetDeparmentTypes());
        }

        public Employee GetCheifEmployeeDepartment(int? idDepartment)
        {
            return ManagerRepository.DepartmentRepository.GetCheifEmployee(idDepartment);
        }

        public BindingList<Department> GetCompanyDeivsionProject(int selectedType)
        {
            return new BindingList<Department>(ManagerRepository.DepartmentRepository.GetDeparmentByType(selectedType));
        }

        public Employee GetCheif(int departmentId)
        {
            return ManagerRepository.DepartmentRepository.GetCheifEmployee(departmentId);
        }

        public DepartmentType GetDeparmentByType(int? id)
        {
            return ManagerRepository.DepartmentRepository.GetDeparmentType(id);
        }

        public void SaveDepartment(Department department)
        {
            ManagerRepository.DepartmentRepository.InsertDepartment(department);
        }

        public void UpdateDepartment(Department department)
        {
            ManagerRepository.DepartmentRepository.UpdateDepartment(department);
        }

        public Department GetDepartmentById(int departmentId)
        {
            return ManagerRepository.DepartmentRepository.GetDepartmentById(departmentId);
        }

        public BindingList<GridCompany> GetDepartmetns()
        {
            return new BindingList<GridCompany>(ManagerRepository.GridCompanyRepository.GetDepartments());
        }

        public GridCompany GetEmployeeDepartment(int? departmentId)
        {
            return ManagerRepository.GridCompanyRepository.GetEmployeeDepartment(departmentId);
        }

        public void SaveEmployee(Employee employee)
        {
            ManagerRepository.EmployeeRespository.InsertEmployee(employee);
        }

        public void NewCompany(string name)
        {
            ManagerRepository.DepartmentRepository.InsertDepartment(new Department()
            {
                Name = name,
                DepartmentType = 1,
                ParentDeparment = null,

            });
        }

        public void DeleteEmployee(Employee employee)
        {
            ManagerRepository.EmployeeRespository.DeleteEmployee(employee);
        }

        public BindingList<GridCompany> GetSelectedCompanyDepartment(int selectedId)
        {
            return new BindingList<GridCompany>(ManagerRepository.GridCompanyRepository.GetDepartments(selectedId));
        }

        public BindingList<Employee> GetEmployees(int selectedId)
        {
            return new BindingList<Employee>(ManagerRepository.EmployeeRespository.GetEmployees(selectedId));
        }

        public GridCompany GetGridCompany(int selectedId)
        {
            return ManagerRepository.GridCompanyRepository.GetGridCompany(selectedId);
        }

        public BindingList<GridCompany> GetCompanies()
        {
            return new BindingList<GridCompany>(ManagerRepository.GridCompanyRepository.GetCompanies());
        }

        public bool GenerateTables()
        {
            ManagerRepository manager = new ManagerRepository();
            return manager.GenerateTables();
        }

        public SqlConnectionStringBuilder GetSqlConnectionStringBuilder()
        {
            ConnectionManager connectionManager = new ConnectionManager();
            return connectionManager.GetSqlConnectionStringBuilder(INITIAL_CATALOG);
        }

        public SqlConnectionStringBuilder GetSqlConnectionStringBuilder(string initialCatalog)
        {
            ConnectionManager connectionManager = new ConnectionManager();
            return connectionManager.GetSqlConnectionStringBuilder(initialCatalog);
        }

        public void SaveConnectionString(string connectionString)
        {
            Properties.Settings.Default.ConnectionString = connectionString;
            Properties.Settings.Default.Save();
        }

        public bool HasDatabase()
        {
            bool ret = false;
            ManagerRepository managerRepository = new ManagerRepository();
            if (managerRepository.GetDataBaseName() == DB_NAME)
            {
                ret = true;
            }
            return ret;
        }
    }
}

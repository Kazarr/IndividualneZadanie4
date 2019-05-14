using Logic;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStructure
{
    public class EmployeeViewModel
    {
        private LogicSystem _logicSystem;
        private Employee _employee;

        public EmployeeViewModel(LogicSystem logic, Employee employee)
        {
            _logicSystem = logic;
            _employee = employee;
        }
        public EmployeeViewModel(LogicSystem logic)
        {
            _logicSystem = logic;
            _employee = new Employee();
        }


        public Employee Employee { get => _employee; set => _employee = value; }

        public BindingList<GridCompany> GetDepartments()
        {
            return _logicSystem.GetDepartmetns();
        }

        public GridCompany GetEmployeeDepartment()
        {
            return _logicSystem.GetEmployeeDepartment(Employee.DepartmentId);
        }

        public void SaveEmployee()
        {
            _logicSystem.SaveEmployee(Employee);
        }
    }
}

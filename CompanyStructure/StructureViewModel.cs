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
    public class StructureViewModel
    {
        public Department Department { get; set; }
        private LogicSystem _logicSystem;

        public StructureViewModel(LogicSystem logic)
        {
            _logicSystem = logic;
            Department = new Department();
        }

        public StructureViewModel(LogicSystem logic, int departmentId)
        {
            _logicSystem = logic;
            Department = _logicSystem.GetDepartmentById(departmentId);
        }

        public string GetDepartmentName()
        {
            return Department.Name;
        }

        public BindingList<Employee> GetAllEmployees()
        {
            return _logicSystem.GetEmployees();
        }

        public Employee GetCheifEmployee(int? idDepartment)
        {
            return _logicSystem.GetCheifEmployeeDepartment(idDepartment);
        }

        public BindingList<DepartmentType> GetDepartmentTypes()
        {
            return _logicSystem.GetDeparmentTypes();
        }

        public DepartmentType GetDepartmentByType(int? id)
        {
            return _logicSystem.GetDeparmentByType(id);
        }

        public BindingList<Department> GetCompanyDivisionProject(int selectedType)
        {
            return _logicSystem.GetCompanyDeivsionProject(selectedType);
        }

        public void SaveDepartment()
        {
            _logicSystem.SaveDepartment(Department);
        }

        public void UpdateDepartment()
        {
            _logicSystem.UpdateDepartment(Department);
        }
    }
}

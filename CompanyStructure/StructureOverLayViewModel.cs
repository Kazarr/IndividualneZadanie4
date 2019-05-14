using Logic;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyStructure
{
    public class StructureOverLayViewModel
    {
        private int _departmentId;

        public LogicSystem LogicSystem { get; set; }
        //public int SelectedId { get; set; }
        public Employee Employee { get; set; }
        public int DepartmentId { get => _departmentId; set { _departmentId = value;
                ChildDepartments = this.GetDepartmentByParent(_departmentId);
            } }
        public List<Department> ChildDepartments { get; set; }
        public Stack<Department> ToTreeDepartments { get; set; }

        public StructureOverLayViewModel(LogicSystem logic)
        {
            LogicSystem = logic;
            ToTreeDepartments = new Stack<Department>();
            //ChildDepartments = new List<Department>();
            //SelectedId = selectedId;
        }
        public BindingList<GridCompany> GetSelectedCompanyDepartment(int selectedId)
        {
            return LogicSystem.GetSelectedCompanyDepartment(selectedId);
        }

        public BindingList<GridCompany> GetCompanies()
        {
            return LogicSystem.GetCompanies();
        }

        public BindingList<Employee> GetEmployess(int selectedId)
        {
            return LogicSystem.GetEmployees(selectedId);
        }

        public BindingList<Employee> GetSelectedDepartmentEmployees(int value)
        {
            return LogicSystem.GetEmployees(value);
        }

        public List<Department> GetDepartmentByParent(int? departmentId)
        {
            return LogicSystem.GetDepartmentByParent(departmentId);
        }

        public void DeleteEmployee()
        {
            LogicSystem.DeleteEmployee(Employee);
        }

        public bool IsCheif()
        {
            if (Employee.Id == LogicSystem.GetCheif(DepartmentId).Id)
            {
                return true;
            }
            return false;
        }

        public string GetSeletedDepartment()
        {
            return LogicSystem.GetSelctedDepartment(DepartmentId).Name;
        }
    }
}

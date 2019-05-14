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
        public LogicSystem LogicSystem { get; set; }
        //public int SelectedId { get; set; }
        public Employee Employee { get; set; }
        public int DepartmentId { get; set; }

        public StructureOverLayViewModel(LogicSystem logic)
        {
            LogicSystem = logic;
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
    }
}

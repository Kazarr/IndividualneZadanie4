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
        public int SelectedId { get; set; }


        public StructureOverLayViewModel(LogicSystem logic, int selectedId)
        {
            LogicSystem = logic;
            SelectedId = selectedId;
        }
        public BindingList<GridCompany> GetSelectedCompanyDepartment(int selectedId)
        {
            return LogicSystem.GetSelectedCompanyDepartment(selectedId);
        }

        public BindingList<Employee> GetEmployess(int selectedId)
        {
            return LogicSystem.GetEmployees(selectedId);
        }
    }
}

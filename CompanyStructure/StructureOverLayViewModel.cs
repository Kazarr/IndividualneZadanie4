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
    public class StructureOverLayViewModel
    {
        public LogicSystem LogicSystem { get; set; }

        public StructureOverLayViewModel(LogicSystem logic)
        {
            LogicSystem = logic;
        }
        public BindingList<GridCompany> GetSelectedCompanyDepartment()
        {
            return null; LogicSystem.GetCompanies();
        }
    }
}

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
    public class CompanyLevelViewModel
    {
        public LogicSystem LogicSystem { get; private set; }
        public CompanyLevelViewModel(LogicSystem logic)
        {
            LogicSystem = logic;
        }

        public BindingList<GridCompany> GetCompanies()
        {
            return LogicSystem.GetCompanies();
        }
    }
}

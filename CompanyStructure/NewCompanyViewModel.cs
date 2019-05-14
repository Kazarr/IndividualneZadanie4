using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace CompanyStructure
{
    public class NewCompanyViewModel
    {
        private LogicSystem _logicSystem;

        public NewCompanyViewModel()
        {
            _logicSystem = new LogicSystem();
        }

        public void NewCompany(string name)
        {
            _logicSystem.NewCompany(name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class Department
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? DepartmentType { get; set; }
        public int? ParentDeparment { get; set; }
        public int? CheifEmployeeId { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

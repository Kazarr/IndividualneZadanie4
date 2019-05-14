﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class Employee
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Degree { get; set; }
        public int? Phone { get; set; }
        public string Mail { get; set; }
        public int? DepartmentId { get; set; }

        public override string ToString()
        {
            return $"{Name} {SurName}";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Models
{
    public class Faculty
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }
}

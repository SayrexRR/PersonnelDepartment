using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Models
{
    public class Teacher : Student
    {
        public bool IsDepartmentHead { get; set; } = false;
        public string Position { get; set; }
    }
}

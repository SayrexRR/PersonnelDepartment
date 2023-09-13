using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Models
{
    public class Department
    {
        public string Name { get; set; }
        public Teacher DepartmentHead { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public Faculty Faculty { get; set; }
    }
}

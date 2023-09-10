using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment
{
    public class Faculty
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
        public Teacher DepartmentHead { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public Faculty Faculty { get; set; }
    }

    public class Group
    {
        public string Name { get; set; }
        public Student GroupLeader { get; set; }
        public Department ProfileDepartment { get; set; }
    }
}

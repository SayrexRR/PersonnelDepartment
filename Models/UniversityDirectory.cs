using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Models
{
    public class UniversityDirectory
    {
        public List<Faculty> Faculties { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Group> Groups { get; set; }
        public List<Department> Departments { get; set; }
    }
}

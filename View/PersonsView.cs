using PersonnelDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.View
{
    public class PersonsView
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; } = string.Empty;
        public string Department { get; set; }
        public Person? Parent { get; set; }
        public List<Person>? Childrens { get; set; }
        public bool IsStudent { get; set; } = false;
        public bool IsTeacher { get; set; } = false;
        public bool IsDepartmentHead { get; set; } = false;
    }
}

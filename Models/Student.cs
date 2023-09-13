using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Models
{
    public class Student : Person
    {
        public Person? Parent { get; set; }
        public Group Group { get; set; }
        public Department Department { get; set; }
    }
}

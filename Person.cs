using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment
{
    public abstract class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public Passport PassportData { get; set; }
        public string Address { get; set; }
    }

    public class Parent : Person
    {
        public List<Student> Childrens { get; set; }
    }

    public class Student : Parent
    {
        public Parent Parent { get; set; }
        public Group Group { get; set; }
        public Department Department { get; set; }
    }

    public class Teacher : Student
    {
        public bool IsDepartmentHead { get; set; } = false;
        public string Position { get; set; }
    }

    
}

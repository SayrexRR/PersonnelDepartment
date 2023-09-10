using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment
{
    public class Initializer
    {
        public static UniversityDirectory Initialize()
        {
            UniversityDirectory directory = new UniversityDirectory();

            Faculty faculty1 = new Faculty { Name = "Економічний" };
            Faculty faculty2 = new Faculty { Name = "Математики і інформатики" };

            Department department1 = new Department { Name = "Кафедра економічної теорії та економічних методів управління" };
            Department department2 = new Department { Name = "Кафедра економічної кібернетики та прикладної економіки" };
            Department department3 = new Department { Name = "Кафедра теоретичної та прикладної інформатики" };
            Department department4 = new Department { Name = "Кафедра фундаментальної математики" };

            faculty1.Departments = new List<Department> { department1, department2 };
            faculty2.Departments = new List<Department> { department3, department4 };

            department1.Faculty = faculty1;
            department2.Faculty = faculty1;
            department3.Faculty = faculty2;
            department4.Faculty = faculty2;

            Teacher teacher1 = new Teacher
            {
                LastName = "Гриценко",
                FirstName = "Андрій",
                MiddleName = "Андрійович",
                Gender = "Чоловік",
                PassportData = new Passport("00052215"),
                Address = "м. Харків",
                Department = department1,
                Position = "Зав. кафедри",
                IsDepartmentHead = true
            };
            Teacher teacher2 = new Teacher
            {
                LastName = "Коломієць",
                FirstName = "Ганна",
                MiddleName = "Миколаївна",
                Gender = "Жінка",
                PassportData = new Passport("00005146", "MA"),
                Address = "м. Харків",
                Department = department1,
                Position = "Викладач"
            };
            Teacher teacher3 = new Teacher
            {
                LastName = "Мірясов",
                FirstName = "Юрій",
                MiddleName = "Олександрович",
                Gender = "Чоловік",
                PassportData = new Passport("004520041"),
                Address = "м. Харків",
                Department = department1,
                Position = "Викладач"
            };
            Teacher teacher4 = new Teacher
            {
                LastName = "Меркулова",
                FirstName = "Тамара",
                MiddleName = "Вікторівна",
                Gender = "Жінка",
                PassportData = new Passport("00105510"),
                Address = "м. Харків",
                Department = department2,
                Position = "Зав. кафедри",
                IsDepartmentHead = true
            };
            Teacher teacher5 = new Teacher
            {
                LastName = "Даніч",
                FirstName = "Віталій",
                MiddleName = "Миколайович",
                Gender = "Чоловік",
                PassportData = new Passport("00105510"),
                Address = "м. Харків",
                Department = department2,
                Position = "Викладач"
            };
            Teacher teacher6 = new Teacher
            {
                LastName = "Меняйлов",
                FirstName = "Євген",
                MiddleName = "Сергійович",
                Gender = "Чоловік",
                PassportData = new Passport("70054201"),
                Address = "м. Харків",
                Department = department3,
                Position = "В/О завідувача кафедри",
                IsDepartmentHead = true
            };
            Teacher teacher7 = new Teacher
            {
                LastName = "Жолткевич",
                FirstName = "Григорій",
                MiddleName = "Миколайович",
                Gender = "Чоловік",
                PassportData = new Passport("1850908"),
                Address = "м. Харків",
                Department = department3,
                Position = "Викладач"
            };
            Teacher teacher8 = new Teacher
            {
                LastName = "Ямпольський",
                FirstName = "Олександр",
                MiddleName = "Леонідович",
                Gender = "Чоловік",
                PassportData = new Passport("00152211", "МК"),
                Address = "м. Харків",
                Department = department4,
                Position = "Зав. кафедри",
                IsDepartmentHead = true
            };
            Teacher teacher9 = new Teacher
            {
                LastName = "Фастовська",
                FirstName = "Тамара",
                MiddleName = "Борисівна",
                Gender = "Жінка",
                PassportData = new Passport("00152211", "МК"),
                Address = "м. Харків",
                Department = department4,
                Position = "Викладач"
            };

            department1.DepartmentHead = teacher1;
            department2.DepartmentHead = teacher4;
            department3.DepartmentHead = teacher6;
            department4.DepartmentHead = teacher8;

            department1.Teachers = new List<Teacher> { teacher1, teacher2, teacher3 };
            department2.Teachers = new List<Teacher> { teacher4, teacher5 };
            department3.Teachers = new List<Teacher> { teacher6, teacher7 };
            department4.Teachers = new List<Teacher> { teacher8, teacher9 };

            Group group1 = new Group { Name = "ЕУ-31", ProfileDepartment = department1 };
            Group group2 = new Group { Name = "ЕП-32", ProfileDepartment = department2 };
            Group group3 = new Group { Name = "МІЕ-45", ProfileDepartment = department3 };
            Group group4 = new Group { Name = "МІП-44", ProfileDepartment = department4 };

            Student student1 = new Student
            {
                LastName = "Філатов",
                FirstName = "Іван",
                MiddleName = "Олександрович",
                Gender = "Чоловік",
                PassportData = new Passport("042144"),
                Address = "Адреса 2",
                Group = group1,
                Department = department1
            };
            Student student2 = new Student
            {
                LastName = "Хардіков",
                FirstName = "Олексій",
                MiddleName = "В'ячеславович",
                Gender = "Чоловік",
                PassportData = new Passport("00054401"),
                Address = "Адреса 2",
                Group = group1,
                Department = department1
            };
            Student student3 = new Student
            {
                LastName = "Новицька",
                FirstName = "Дар'я",
                Group = group1,
                MiddleName = "Романівна",
                Gender = "Жінка",
                PassportData = new Passport("000041441"),
                Address = "Адреса 2",
                Department = department1
            };
            Student student4 = new Student
            {
                LastName = "Попова",
                FirstName = "Аліна",
                MiddleName = "Дмитрівна",
                Gender = "Жінка",
                PassportData = new Passport("0000402"),
                Address = "Адреса 2",
                Group = group2,
                Department = department2
            };
            Student student5 = new Student
            {
                LastName = "Ковальов",
                FirstName = "Владислав",
                MiddleName = "Максимович",
                Gender = "Чоловік",
                PassportData = new Passport("0003214"),
                Address = "Адреса 2",
                Group = group2,
                Department = department2
            };
            Student student6 = new Student
            {
                LastName = "Ковальов",
                FirstName = "Святослав",
                MiddleName = "Станіславович",
                Gender = "Чоловік",
                PassportData = new Passport("0071004"),
                Address = "Адреса 2",
                Group = group2,
                Department = department2
            };
            Student student7 = new Student
            {
                LastName = "Скворцова",
                FirstName = "Олександра",
                MiddleName = "Сергіївна",
                Gender = "Жінка",
                PassportData = new Passport("0051120"),
                Address = "Адреса 2",
                Group = group2,
                Department = department2
            };
            Student student8 = new Student
            {
                LastName = "Схабицька",
                FirstName = "Марія",
                MiddleName = "Петрівна",
                Gender = "Жінка",
                PassportData = new Passport("0120412"),
                Address = "Адреса 2",
                Group = group3,
                Department = department3
            };
            Student student9 = new Student
            {
                LastName = "Лященко",
                FirstName = "Андрій",
                MiddleName = "Вадимович",
                Gender = "Чоловік",
                PassportData = new Passport("2014500"),
                Address = "Адреса 2",
                Group = group3,
                Department = department3
            };
            Student student10 = new Student
            {
                LastName = "Макаренко",
                FirstName = "Владислав",
                MiddleName = "Володимирович",
                Gender = "Чоловік",
                PassportData = new Passport("0851230"),
                Address = "Адреса 2",
                Group = group3,
                Department = department3
            };
            Student student11 = new Student
            {
                LastName = "Немченко",
                FirstName = "Станіслав",
                MiddleName = "Сергійович",
                Gender = "Чоловік",
                PassportData = new Passport("0000142"),
                Address = "Адреса 2",
                Group = group4,
                Department = department4,
                Childrens = new List<Student> { student7 }
            };
            student7.Parent = student11;

            Student student12 = new Student
            {
                LastName = "Задорожня",
                FirstName = "Олександра",
                MiddleName = "Олександрівна",
                Gender = "Жінка",
                PassportData = new Passport("0100453"),
                Address = "Адреса 2",
                Group = group4, 
                Department = department4
            };
            Student student13 = new Student
            {
                LastName = "Пивоваров",
                FirstName = "Кирило",
                MiddleName = "Миколайович",
                Gender = "Чоловік",
                PassportData = new Passport("014254"),
                Address = "Адреса 2",
                Group = group4,
                Department = department4
            };
            Student student14 = new Student
            {
                LastName = "Крот",
                FirstName = "Данило",
                MiddleName = "Павлович",
                Gender = "Чоловік",
                PassportData = new Passport("150042"),
                Address = "Адреса 2",
                Group = group4,
                Department = department4
            };

            Parent parent1 = new Parent
            {
                LastName = "Думіна",
                FirstName = "Людмила",
                MiddleName = "Володимирівна",
                Gender = "Жінка",
                PassportData = new Passport("140008"),
                Address = "Адреса 2",
                Childrens = new List<Student> { student1, student5 }
            };

            student1.Parent = parent1;
            student5.Parent = parent1;

            teacher6.Parent = teacher2;
            teacher6.Group = group3;
            teacher6.Department = department3;
            teacher2.Childrens = new List<Student> { teacher6 };

            group1.GroupLeader = student1;
            group2.GroupLeader = student4;
            group3.GroupLeader = student8;
            group4.GroupLeader = student11;

            department1.Students = new List<Student> { student1, student2, student3 };
            department2.Students = new List<Student> { student4, student5, student6, student7 };
            department3.Students = new List<Student> { student8, student9, student10, teacher6 };
            department4.Students = new List<Student> { student11,  student12, student13, student14 };

            List<Faculty> faculties = new List<Faculty> { faculty1, faculty2 };
            List<Student> students = new List<Student>
            {
                student1, student2, student3, student4,
                student5, student6, student7, student8,
                student9, teacher6, student10, student11,
                student12, student13, student14
            };
            List<Teacher> teachers = new List<Teacher>
            {
                teacher1, teacher2, teacher3, teacher4, teacher5,
                teacher6, teacher7, teacher8, teacher9
            };

            List<Group> groups = new List<Group> { group1, group2, group3, group4 };

            List<Department> departments = new List<Department> { department1, department2, department3, department4 };

            directory.Students = students;
            directory.Groups = groups;
            directory.Teachers = teachers;
            directory.Faculties = faculties;
            directory.Departments = departments;

            return directory;
        }
    }
}

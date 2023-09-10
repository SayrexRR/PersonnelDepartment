using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonnelDepartment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UniversityDirectory universityDirectory = new UniversityDirectory();
        private List<MyTable> students = new List<MyTable>();
        private List<MyTable> teachers = new List<MyTable>();

        public MainWindow()
        {
            universityDirectory = Initializer.Initialize();
            InitializeComponent();
            filterLabel.Content = "Фільтр";
            filter1.IsEnabled = false;

            foreach (var student in universityDirectory.Students)
            {
                students.Add(new MyTable
                {
                    LastName = student.LastName,
                    FirstName = student.FirstName,
                    MiddleName = student.MiddleName,
                    Faculty = student.Department.Faculty.Name,
                    Group = student.Group.Name,
                    Department = student.Department.Name
                });
            }

            foreach (var teacher in universityDirectory.Teachers)
            {
                teachers.Add(new MyTable
                {
                    LastName = teacher.LastName,
                    FirstName = teacher.FirstName,
                    MiddleName = teacher.MiddleName,
                    Faculty = teacher.Department.Faculty.Name,
                    Department = teacher.Department.Name
                });
            }
        }

        

        private void tables_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filter1.Items.Clear();
            filterLabel.Content = "Фільтр";
            filter1.IsEnabled = true;

            if (tables.SelectedIndex == 0)
            {
                persons.ItemsSource = students;

                filterLabel.Content = "Групи";

                foreach (var group in universityDirectory.Groups)
                {
                    filter1.Items.Add(group.Name);
                }
            }
            if (tables.SelectedIndex == 1)
            {
                persons.ItemsSource = teachers;

                filterLabel.Content = "Факультети";

                foreach (var faculty in universityDirectory.Faculties)
                {
                    filter1.Items.Add(faculty.Name);
                }
            }
            if (tables.SelectedIndex == 2)
            {
                filter1.IsEnabled = false;

                var studentsWithoutParents = universityDirectory.Students
                    .Where(s => s.Parent == null)
                    .Select(s => new
                    {
                        s.LastName,
                        s.FirstName,
                        s.MiddleName,
                        Faculty = s.Department.Faculty.Name,
                        Group = s.Group.Name,
                        Department = s.Department.Name
                    });

                persons.ItemsSource = studentsWithoutParents;
            }
            if (tables.SelectedIndex == 3)
            {
                filter1.IsEnabled = false;

                var departmentHead = universityDirectory.Teachers
                    .Where(t => t.IsDepartmentHead == true)
                    .Select(t => new
                    {
                        t.LastName,
                        t.FirstName,
                        t.MiddleName,
                        Faculty = t.Department.Faculty.Name,
                        Department = t.Department.Name
                    });

                persons.ItemsSource = departmentHead;
            }

            if (tables.SelectedIndex == 4)
            {
                filter1.IsEnabled = false;

                var departmentHead = universityDirectory.Teachers
                    .Where(t => t.Childrens is not null)
                    .Select(t => new
                    {
                        t.LastName,
                        t.FirstName,
                        t.MiddleName,
                        Faculty = t.Department.Faculty.Name,
                        Department = t.Department.Name
                    });

                persons.ItemsSource = departmentHead;
            }
        }

        private void filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tables.SelectedIndex == 0)
            {
                var filterSudents = students.Where(s => s.Group == filter1.SelectedValue);
                persons.ItemsSource = filterSudents;
            }

            if (tables.SelectedIndex == 1)
            {
                var filterTeachers = teachers.Where(t => t.Faculty == filter1.SelectedValue);
                persons.ItemsSource = filterTeachers;
            }
        }
    }
}

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
using PersonnelDepartment.Models;
using PersonnelDepartment.View;

namespace PersonnelDepartment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UniversityDirectory universityDirectory = new UniversityDirectory();
        private List<PersonsView> personsView = new List<PersonsView>();


        public MainWindow()
        {
            universityDirectory = Initializer.Initialize();
            InitializeComponent();
            filterLabel.Content = "Фільтр";
            filter1.Visibility = Visibility.Hidden;
            filterLabel.Visibility = Visibility.Hidden;

            var mappedStudents = universityDirectory.Students.Select(s => new PersonsView
            {
                LastName = s.LastName,
                FirstName = s.FirstName,
                MiddleName = s.MiddleName,
                Faculty = s.Department.Faculty.Name,
                Group = s.Group.Name,
                Department = s.Department.Name,
                IsStudent = true,
                Childrens = s.Childrens,
                Parent = s.Parent
            });

            var mappedTeachers = universityDirectory.Teachers.Select(t => new PersonsView
            {
                LastName = t.LastName,
                FirstName = t.FirstName,
                MiddleName = t.MiddleName,
                Faculty = t.Department.Faculty.Name,
                Department = t.Department.Name,
                IsTeacher = true,
                IsDepartmentHead = t.IsDepartmentHead,
                Childrens = t.Childrens
            });

            personsView.AddRange(mappedStudents);
            personsView.AddRange(mappedTeachers);
        }

        

        private void tables_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filter1.Items.Clear();
            filterLabel.Visibility= Visibility.Hidden;
            filter1.Visibility = Visibility.Hidden;

            if (tables.SelectedIndex == 0)
            {
                filterLabel.Visibility = Visibility.Visible;
                filter1.Visibility = Visibility.Visible;

                persons.ItemsSource = personsView.Where(s => s.IsStudent);

                filterLabel.Content = "Групи";

                foreach (var group in universityDirectory.Groups)
                {
                    filter1.Items.Add(group.Name);
                }
            }

            if (tables.SelectedIndex == 1)
            {
                filterLabel.Visibility = Visibility.Visible;
                filter1.Visibility = Visibility.Visible;

                persons.ItemsSource = personsView.Where(t => t.IsTeacher);

                filterLabel.Content = "Факультети";

                foreach (var faculty in universityDirectory.Faculties)
                {
                    filter1.Items.Add(faculty.Name);
                }
            }

            if (tables.SelectedIndex == 2)
            {
                persons.ItemsSource = personsView
                    .Where(s => s.IsStudent)
                    .Where(s => s.Parent is null);
            }

            if (tables.SelectedIndex == 3)
            {
                persons.ItemsSource = personsView.Where(t => t.IsDepartmentHead);
            }

            if (tables.SelectedIndex == 4)
            {
                persons.ItemsSource = personsView
                    .Where(t => t.IsTeacher)
                    .Where(t => t.Childrens is not null);
            }
        }

        private void filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tables.SelectedIndex == 0)
            {
                var filterSudents = personsView
                    .Where(s => s.IsStudent)
                    .Where(s => s.Group?.ToUpper() == filter1.SelectedValue?.ToString()?.ToUpper());
                persons.ItemsSource = filterSudents;
            }

            if (tables.SelectedIndex == 1)
            {
                var filterTeachers = personsView
                    .Where(t => t.IsTeacher)
                    .Where(t => t.Faculty?.ToUpper() == filter1.SelectedValue?.ToString()?.ToUpper());
                persons.ItemsSource = filterTeachers;
            }
        }

        private void persons_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (persons.SelectedItem != null)
            {
                PersonsView selectedPerson = (PersonsView)persons.SelectedItem;

                EditPerson editPersonView = new EditPerson(selectedPerson);
                editPersonView.ShowDialog();

                persons.Items.Refresh();
            }
        }
    }
}

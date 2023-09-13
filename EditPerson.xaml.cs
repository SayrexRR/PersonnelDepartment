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
using System.Windows.Shapes;
using PersonnelDepartment.View;

namespace PersonnelDepartment
{
    /// <summary>
    /// Логика взаимодействия для EditPerson.xaml
    /// </summary>
    public partial class EditPerson : Window
    {
        private PersonsView person;

        public EditPerson(PersonsView personsView)
        {
            InitializeComponent();

            person = personsView;

            lastName.Text = personsView.LastName;
            firstName.Text = personsView.FirstName;
            middleName.Text = personsView.MiddleName;
            faculty.Text = personsView.Faculty;
            group.Text = personsView.Group;
            department.Text = personsView.Department;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            person.LastName = lastName.Text;
            person.FirstName = firstName.Text;
            person.MiddleName = middleName.Text;
            person.Faculty = faculty.Text;
            person.Group = group.Text;
            person.Department = department.Text;

            Close();
        }
    }
}

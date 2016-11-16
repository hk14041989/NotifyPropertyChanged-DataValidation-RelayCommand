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

namespace DataChangedNotificationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NotifiableCollection<Person> _persons;

        public MainWindow()
        {
            InitializeComponent();

            _persons = new NotifiableCollection<Person>
        {
            new Person{Name="Eros"},
            new Person{Name="Tethys"},
            new Person{Name="Atlas"},
            new Person{Name="Apollo"},
            new Person{Name="Hades"},
        };
            this.DataContext = _persons;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            _persons.Add(new Person { Name = textBox1.Text });
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
                _persons[listBox1.SelectedIndex].Name = textBox1.Text;
        }

        private void replaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                _persons[listBox1.SelectedIndex] = new Person { Name = textBox1.Text };
                listBox1.Items.Refresh();
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            _persons.Clear();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var p = (sender as Button).DataContext as Person;
            _persons.Remove(p);
        }
    }
}

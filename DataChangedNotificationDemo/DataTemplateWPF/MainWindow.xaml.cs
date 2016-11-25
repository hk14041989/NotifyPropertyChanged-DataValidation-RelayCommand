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

namespace DataTemplateWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Age=27, Name="Kien"});
            persons.Add(new Person() { Age=20, Name="Hung"});
            persons.Add(new Person() { Age=26, Name="Tung"});

            this.DataContext = persons;
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonHighlightTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item,
                                                    DependencyObject container)
        {
            Person person = item as Person;
            FrameworkElement element = container as FrameworkElement;

            if (person != null && element != null)
            {
                if (person.Name == "Kien")
                {
                    return element.FindResource("HighlightTemplate") as DataTemplate;
                }
                else
                {
                    return element.FindResource("DefaultTemplate") as DataTemplate;
                }
            }

            return null;
        }
    }
}

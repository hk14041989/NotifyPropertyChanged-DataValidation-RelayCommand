using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RelayCommand
{
    class MyViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public MyViewModel()
        {
            Persons = new ObservableCollection<Person>
        {
            new Person{Name="Eros"},
            new Person{Name="Tethys"},
            new Person{Name="Atlas"},
            new Person{Name="Apollo"},
            new Person{Name="Hades"},
        };

            DeleteCommand = new RelayCommand<Person>(
                (p) => p != null, // CanExecute()
                (p) => Persons.Remove(p) // Execute()
                );
            AddCommand = new RelayCommand<string>(
                (s) => true, // CanExecute()
                (s) => Persons.Add(new Person { Name = s }) // Execute()
                );
        }
    }
}

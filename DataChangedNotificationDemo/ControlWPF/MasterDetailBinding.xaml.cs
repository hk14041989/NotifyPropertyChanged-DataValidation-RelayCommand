using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ControlWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            ObservableCollection<Category> categories = new ObservableCollection<Category>();

            categories.Add(new Category("Antivirus",
                                        new Product(1, "Norton"),
                                        new Product(2, "Kaspersky"),
                                        new Product(3, "AVG")));

            categories.Add(new Category("Browsers",
                                        new Product(4, "FireFox"),
                                        new Product(5, "Chrome"),
                                        new Product(6, "Opera")));

            categories.Add(new Category("Game",
                                        new Product(7, "Need for Speed"),
                                        new Product(8, "Age of Empires"),
                                        new Product(9, "Road Rash")));

            this.DataContext = categories;
        }
    }

    class Category
    {
        public string Name { get; set; }
        public ObservableCollection<Product> Products { get; set; }

        public Category(string name, params Product[] products)
        {
            this.Name = name;
            Products = new ObservableCollection<Product>();
            foreach (Product p in products)
            {
                Products.Add(p);
            }
        }

    }
    class Product
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public Product(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}

using System.Collections.Generic;
using System.Windows;

namespace ControlWPF
{
    /// <summary>
    /// Interaction logic for Hierarchical.xaml
    /// </summary>
    /// 
    public partial class Hierarchical : Window
    {
        public Hierarchical()
        {
            InitializeComponent();

            var categories = new List<Category1>();

            var cat1 = new Category1() { CategoryName = "Antivirus" };
            cat1.Products.Add(new Product1() { ProductID = 1, ProductName = "Norton AV" });
            cat1.Products.Add(new Product1() { ProductID = 2, ProductName = "Kaspersky" });
            cat1.Products.Add(new Product1() { ProductID = 3, ProductName = "AVG" });

            var cat2 = new Category1() { CategoryName = "Browser" };
            cat2.Products.Add(new Product1() { ProductID = 4, ProductName = "Firefox" });
            cat2.Products.Add(new Product1() { ProductID = 5, ProductName = "Chrome" });
            cat2.Products.Add(new Product1() { ProductID = 6, ProductName = "Opera" });

            var cat3 = new Category1() { CategoryName = "Game" };
            cat3.Products.Add(new Product1() { ProductID = 7, ProductName = "FreeCell" });
            cat3.Products.Add(new Product1() { ProductID = 8, ProductName = "Hearts" });
            cat3.Products.Add(new Product1() { ProductID = 9, ProductName = "Minesweeper" });

            categories.Add(cat1);
            categories.Add(cat2);
            categories.Add(cat3);

            this.DataContext = categories;
        }
    }

    public class Product1
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }
    }

    public class Category1
    {
        public string CategoryName { get; set; }
        public List<Product1> Products { get; set; }

        public Category1()
        {
            Products = new List<Product1>();
        }
    }
}

using System.Windows;
using MVVMLightTemplate.ViewModel;
using MVVMLightTemplate.Skins;

namespace MVVMLightTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void OpenForm(object sender, RoutedEventArgs e)
        {
            MvvmView1 view = new MvvmView1();
            view.ShowDialog();
        }
    }
}
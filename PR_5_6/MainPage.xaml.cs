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
using System.Collections.ObjectModel;

namespace PR_5_6
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static ObservableCollection<Product> products { get; set; }
        public MainPage()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>(bd_connection.aAAAEntities.Product.ToList());
            var Prod = new Product();
            this.DataContext = this;
        }

        private void prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var n = (sender as ListView).SelectedItem as Product;

            NavigationService.Navigate(new BuyPage(n));
        }
    }
}

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
            HashSet<string> proiz = new HashSet<string>();

            foreach (var i in products)
            {
                proiz.Add(i.Proizvoditel);
            }

            foreach (var i in proiz)
            {
                cb_Proizvod.Items.Add(i);
            }
        }

        private void prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var n = (sender as ListView).SelectedItem as Product;

            NavigationService.Navigate(new BuyPage(n));
        }

        private void tb_Poisk_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (tb_Poisk.Text != "")
            {
                prod.SelectedItem = null;
                prod.ItemsSource = new ObservableCollection<Product>(bd_connection.aAAAEntities.Product.Where(z => (z.Name.Contains(tb_Poisk.Text) || z.Opisanie.Contains(tb_Poisk.Text))).ToList());
            }
        }

        private void cb_Proizvod_Selected(object sender, RoutedEventArgs e)
        {
            prod.SelectedItem = null;
            prod.ItemsSource = new ObservableCollection<Product>(bd_connection.aAAAEntities.Product.Where(z => (z.Proizvoditel.Contains((cb_Proizvod.SelectedItem).ToString()))).ToList());
        }

        private void btn_Filtr_Click(object sender, RoutedEventArgs e)
        {
            //List<string> produ = new List<string>();
            //btn_Filtr.Content = "По возрастанию";
            //foreach (var i in products)
            //{
            //    prod = i.ID;
            //}

            //prod.SelectedItem = null;
            //prod.ItemsSource = new ObservableCollection<Product>(bd_connection.aAAAEntities.Product.Where(z => (z.Stoimost.HasValue))).ToList());
        }
    }
}

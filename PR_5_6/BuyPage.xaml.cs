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

namespace PR_5_6
{
    /// <summary>
    /// Логика взаимодействия для BuyPage.xaml
    /// </summary>
    public partial class BuyPage : Page
    {
        public BuyPage(Product n)
        {
            InitializeComponent();
            tb_Name.Text = n.Name;

            cb_VidOplaty.Items.Add("Наличными при получении");
            cb_VidOplaty.Items.Add("Банковская карта");
            cb_VidOplaty.Items.Add("Google Pay");
            cb_VidOplaty.Items.Add("Apple Pay");
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

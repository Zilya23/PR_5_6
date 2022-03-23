﻿using System;
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
        public static Product tovar;
        public static int count = 0;
        public BuyPage(Product n)
        {
            InitializeComponent();
            tb_Name.Text = n.Name;
            tovar = n;

            cb_VidOplaty.Items.Add("Наличными при получении");
            cb_VidOplaty.Items.Add("Банковская карта");
            cb_VidOplaty.Items.Add("Google Pay");
            cb_VidOplaty.Items.Add("Apple Pay");

            cb_Poluch.Items.Add("Самовывоз");
            cb_Poluch.Items.Add("Доставка");
            cb_Poluch.Items.Add("Срочная доставка");
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void cb_Poluch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cb_Poluch.SelectedItem.ToString() != "Самовывоз")
            {
                tb_Adr.Visibility = Visibility;
                tb_Adres.Visibility = Visibility;
            }
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            count = Convert.ToInt32((tb_Kol.Text));
            if (tovar.Kolichestvo > Convert.ToInt32((tb_Kol.Text)))
            {
                count++;
                tb_Kol.Text = count.ToString();
            }
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            count = Convert.ToInt32((tb_Kol.Text));
            if (0 < Convert.ToInt32((tb_Kol.Text)))
            {
                count--;
                tb_Kol.Text = count.ToString();
            }
        }
    }
}

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

namespace TeamProject_Beta.Pages
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Page
    {
        public Basket()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                ListViewBuskerOut.Items.Add(1);
            }
        }

        private void DeleteFromBusketTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Удалено");
        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DeleteAllProductInBusket_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Все удалено");
        }

        private void ProductNameTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new ProgramsShopPage());
        }
    }
}

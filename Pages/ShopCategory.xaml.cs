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
    /// Логика взаимодействия для ShopCategory.xaml
    /// </summary>
    public partial class ShopCategory : Page
    {
        public ShopCategory(string CategoryName)
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++) //Удаляй !!!!!!!!!!!!!!!!!1
            {
                ListViewProductOut.Items.Add(1);
            }

            //MessageBox.Show(CategoryName);
        }

        private void GridSingleProduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new ProgramsShopPage());
        }
    }
}

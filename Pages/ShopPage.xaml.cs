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
    /// Логика взаимодействия для ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        public ShopPage()
        {
            InitializeComponent();
            LoadBtnImage();
            ScrollImage.PreviewMouseWheel += ScrollImage_PreviewMouseWheel;
            ScrollCategory.PreviewMouseWheel += ScrollCategory_PreviewMouseWheel;

            for (int i = 0; i < 20; i++)
            {
                ListViewProductOut.Items.Add(1);
            }
        }

        private void ScrollImage_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                ScrollImage.LineLeft();
            }
            else if (e.Delta < 0)
            {
                ScrollImage.LineRight();
            }
            e.Handled = true;
        }

        private void ScrollCategory_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                ScrollCategory.LineLeft();
            }
            else if (e.Delta < 0)
            {
                ScrollCategory.LineRight();
            }
            e.Handled = true;
        }

        public void LoadBtnImage()
        {
            Button btn;

            string NameBtn = "Btn";
            int CountBtn = 1;


            for (int i = 0; i < 10; i++)
            {
                btn = new Button
                {
                    Name = NameBtn + CountBtn.ToString(),
                    Width = 100,
                    Height = 40,
                    Content = "Категория"
                };

                btn.Click += BtnCategoryClick;

                CategoryListView.Children.Add(btn);

                CountBtn++;
            }
        }

        private void BtnCategoryClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(((Button)sender).Name.ToString());

            NavigationService.Navigate(new ShopCategory(((Button)sender).Content.ToString()));
        }

        private void GridSingleProduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new ProgramsShopPage());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new ProgramsShopPage());
        }
    }
}

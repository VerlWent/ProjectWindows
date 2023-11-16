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
using Xceed.Wpf.Toolkit.Core.Converters;

namespace TeamProject_Beta.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProgramsShopPage.xaml
    /// </summary>
    public partial class ProgramsShopPage : Page
    {
        public ProgramsShopPage()
        {
            InitializeComponent();
            ScrollCategory.PreviewMouseWheel += ScrollCategory_PreviewMouseWheel;
            LoadBtnImage();
            LoadBtnCategory();
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

        private void BtnCategoryClick(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Content.ToString());

            NavigationService.Navigate(new ShopCategory(((Button)sender).Content.ToString()));
        }

            public void LoadBtnCategory()
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
                    Margin = new Thickness(5,0,0,0),
                    Content = "Категория"
                };

                btn.Click += BtnCategoryClick;

                CategoryListView.Children.Add(btn);

                CountBtn++;
            }
        }

        public void LoadBtnImage()
        {
            BitmapImage bitmapImage;
            Image image;

            for (int i = 0; i < 5; i++)
            {
                string ImagePath = "C:\\Users\\VerlWent\\source\\repos\\TeamProject_Beta\\Resources\\Images\\Cube.png";
                bitmapImage = new BitmapImage(new Uri(ImagePath));
                image = new Image() { Source = bitmapImage };

                IMGListView.Items.Add(image);
            }

            BitmapImage IMG = new BitmapImage(new Uri("C:\\Users\\VerlWent\\source\\repos\\TeamProject_Beta\\Resources\\Images\\background.jpg"));
            MainImage.Source = IMG;

        }
    }
}

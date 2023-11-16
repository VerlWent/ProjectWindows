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
using System.Windows.Shapes;
using TeamProject_Beta.Pages;
using Xceed.Wpf.Toolkit;

namespace TeamProject_Beta.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow(int num)
        {
            InitializeComponent();
            if (num == 1)
            {
                MainFrame.Navigate(new ProgramsShopPage());
            }
            else if (num == 2)
            {
                MainFrame.Navigate(new ShopPage());
            }
            else if (num == 3)
            {
                MainFrame.Navigate(new Basket());
            }
        }
    }
}

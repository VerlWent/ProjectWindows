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

namespace TeamProject_Beta.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindows.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void ShopProgramPage_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow CW = new ClientWindow(1);
            CW.Show();
            this.Close();
        }

        private void WorkerSupportWindow_Click(object sender, RoutedEventArgs e)
        {
            SupportWindows SW = new SupportWindows();
            SW.Show();
            this.Close();
        }

        private void ShopPage_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow CW = new ClientWindow(2);
            CW.Show();
            this.Close();
        }

        private void BusketPage_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow CW = new ClientWindow(3);
            CW.Show();
            this.Close();
        }
    }
}

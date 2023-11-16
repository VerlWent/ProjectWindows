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
    /// Логика взаимодействия для MainSupportPage.xaml
    /// </summary>
    public partial class MainSupportPage : Page
    {
        public MainSupportPage()
        {
            InitializeComponent();
            ListViewSupportAllRequests.Items.Add(10);
        }

        private void AllRequests_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewRequests_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ActiveRequests_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CompletedRequests_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new DescrtiptionSupportPage());
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            string messegeExit = "Вы уверены?";
            string caption = "Выход";
            MessageBoxButton btn = MessageBoxButton.YesNo;
            MessageBoxImage btnicon = MessageBoxImage.Question;
            MessageBoxResult btnresult;
            btnresult = MessageBox.Show(messegeExit, caption, btn, btnicon);

            switch (btnresult)
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                FocusManager.SetFocusedElement(FocusManager.GetFocusScope(element), null);
                Keyboard.ClearFocus();
            }
        }
    }
}

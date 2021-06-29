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

namespace test
{
    /// <summary>
    /// Table.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Table : Page
    {
        public Table()
        {
            InitializeComponent();
            if (Commons.tb[0] == false)
                btntb1.IsEnabled = false;
            if (Commons.tb[1] == false)
                btntb2.IsEnabled = false;
            if (Commons.tb[2] == false)
                btntb3.IsEnabled = false;
            if (Commons.tb[3] == false)
                btntb4.IsEnabled = false;
            if (Commons.seat.Count == 4)
            {
                TxtWait.Visibility = Visibility.Visible;
                BtnWait.IsEnabled = true;
            }
        }

        private void btntb1_Click(object sender, RoutedEventArgs e)
        {
            Commons.seat.Add(1);
            Commons.tb[0] = false;
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }

        private void btntb2_Click(object sender, RoutedEventArgs e)
        {
            Commons.seat.Add(2);
            Commons.tb[1] = false;
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }

        private void btntb3_Click(object sender, RoutedEventArgs e)
        {
            Commons.seat.Add(3);
            Commons.tb[2] = false;
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }

        private void btntb4_Click(object sender, RoutedEventArgs e)
        {
            Commons.seat.Add(4);
            Commons.tb[3] = false;
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void BtnWait_Click(object sender, RoutedEventArgs e)
        {
            Commons.wait++;
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }
    }
}

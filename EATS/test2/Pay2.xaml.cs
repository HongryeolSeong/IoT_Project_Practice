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
    /// Pay2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Pay2 : Page
    {
        public Pay2()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Final.xaml", UriKind.Relative));
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pay.xaml", UriKind.Relative));
        }
    }
}

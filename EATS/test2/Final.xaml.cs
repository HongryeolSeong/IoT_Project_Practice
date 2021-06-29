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
using System.Windows.Forms;

namespace test
{
    /// <summary>
    /// Final.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Final : Page
    {
        public event EventHandler Shown;

        public Final()
        {
            InitializeComponent();
            Loaded += Final_Loaded;
        }

        private void Final_Loaded(object sender, RoutedEventArgs e)
        {
            TxtTable.Text = $"선택하신 테이블은 {Commons.seat[Commons.seat.Count - 1]}번 입니다.";
        }

        private void BtnEnd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }
    }
}

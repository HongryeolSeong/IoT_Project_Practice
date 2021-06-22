using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu : Page
    {
        class Order
        {
            public int num = 0;
        }
        private string m;

        Order a = new Order();
        Order b = new Order();
        Order c = new Order();
        Order d = new Order();

        public Menu()
        {
            InitializeComponent();
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            /*TxtRes.Text = string.Format("주문된 메뉴는 {0}이고,\n" +
                " 수량은 A:{1}개, B:{2}개\n" +
                "          C:{3}개, D:{4}개 입니다.",
                m, a.num, b.num, c.num, d.num);
            Delay(5000);*/
            NavigationService.Navigate(new Uri("/Pay.xaml", UriKind.Relative));
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Table.xaml", UriKind.Relative));
        }
    }
}

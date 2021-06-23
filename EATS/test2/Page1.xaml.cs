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
using System.Windows.Threading;

namespace test
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {
        private object wnum = 0;

        public Page1()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Dclock.Text = DateTime.Now.ToString();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Table.xaml", UriKind.Relative));
        }

        private void TxtWait_Loaded(object sender, RoutedEventArgs e)
        {
            TxtWait.Text = string.Format("현재 대기 팀은 {0}팀 이고,\n" +
                "예상 대기 시간은 00:00입니다.", wnum);
        }
    }
}

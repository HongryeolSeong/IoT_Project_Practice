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
            Shown += Final_Shown;
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

        private void Final_Shown(object sender, EventArgs e)
        {
            Delay(1000);
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

    }
}

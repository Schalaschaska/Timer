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

namespace Timer_test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        DispatcherTimer Timer = new DispatcherTimer();
        public int sec, min, hour;

        public Window2()
        {
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += new EventHandler(timer);
        }
        void timer(object obj, EventArgs e)
        {
            label1.Content = hour.ToString() + " : " + min.ToString() + " : " + sec++.ToString();
            if (sec % 60 == 0)
            {
                sec = 0;
                label1.Content = hour.ToString() + " : " + min++.ToString() + " : " + sec++.ToString();
                if (min % 60 == 0)
                {
                    sec = 0;
                    min = 0;
                    label1.Content = hour++.ToString() + " : " + min++.ToString() + " : " + sec++.ToString();
                }

            }

        }

        private void startB_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }

        private void pauseB_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }

        private void stopB_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "0 : 0 : 0";
        }

    }
}

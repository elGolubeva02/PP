using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private MediaPlayer player = new MediaPlayer();
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string path = @".\voice";
            string s = System.IO.Path.GetFullPath(path) + @"\введение.mp3";
            s = s.Replace(@"\bin\Debug", "");
            player.Open(new Uri(s, UriKind.Relative));
            player.Play();
        }

        private void MyWipedText9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Memo().Show();
            int ind = 1;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void MyWipedText10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Memo().Show();
            int ind = 2;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void MyWipedText11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Memo().Show();
            int ind = 3;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void MyWipedText12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Memo().Show();
            int ind = 4;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void MyWipedText13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Memo().Show();
            int ind = 5;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();

            MyWipedText.Visibility = Visibility.Collapsed;
            MyWipedText2.Visibility = Visibility.Collapsed;
            MyWipedText3.Visibility = Visibility.Collapsed;
            MyWipedText4.Visibility = Visibility.Collapsed;
            MyWipedText5.Visibility = Visibility.Collapsed;
            MyWipedText6.Visibility = Visibility.Collapsed;
            MyWipedText7.Visibility = Visibility.Collapsed;
            MyWipedText8.Visibility = Visibility.Collapsed;
            MyWipedText9.Visibility = Visibility.Collapsed;
            MyWipedText10.Visibility = Visibility.Collapsed;
            MyWipedText11.Visibility = Visibility.Collapsed;
            MyWipedText12.Visibility = Visibility.Collapsed;
            MyWipedText13.Visibility = Visibility.Collapsed;

            text.Visibility = Visibility.Visible;
            text2.Visibility = Visibility.Visible;
            text3.Visibility = Visibility.Visible;
            text4.Visibility = Visibility.Visible;
            text5.Visibility = Visibility.Visible;
            text6.Visibility = Visibility.Visible;
            text7.Visibility = Visibility.Visible;
            text8.Visibility = Visibility.Visible;
            var1.Visibility = Visibility.Visible;
            var2.Visibility = Visibility.Visible;
            var3.Visibility = Visibility.Visible;
            var4.Visibility = Visibility.Visible;
            var5.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Start().Show();
            this.Close();
        }
    }
}

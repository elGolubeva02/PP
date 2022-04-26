using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public string img { get; set; }
        public int s { get; set; }
        int fon = 0;
        public Start()
        {
            InitializeComponent();
            bb = "#FFFF8000";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            img = "/img/голос.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img"));
        }

        private void tem1_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem2_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem3_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem4_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem5_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem6_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem7_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem8_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem9_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem10_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem11_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem12_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem13_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem14_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem15_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem16_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem17_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem18_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tem19_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

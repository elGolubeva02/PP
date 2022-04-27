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
using test.windowsTeor;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        //public string img { get; set; }
        public int s { get; set; }
        int fon = 0;
        public Start()
        {
            InitializeComponent();
            //fon = f; s = sz;
            //if (fon == 0)
            //{
                bb = "#FFFF8000";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
                s = 24;
                PropertyChanged(this, new PropertyChangedEventArgs("s"));
                fg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            //}
            //else if (fon == 1)
            //{
            //    bg = "#000000";
            //    PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            //    bb = "#ffff00";
            //    PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            //    fg = "#ffff00";
            //    PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            //}
            //else if (fon == 2)
            //{
            //    bg = "#99ccff";
            //    PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            //    bb = "#0f6cbf";
            //    PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            //    fg = "#0f6cbf";
            //    PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            //}
            //img = "/img/голос.png";
            //PropertyChanged(this, new PropertyChangedEventArgs("img"));
        }

        private void tem1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new Lecsica(fon, s).ShowDialog();
            //this.Close();
        }

        private void tem2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Predlog(fon, s).Show();
            this.Close();
        }

        private void tem3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new Times(fon, s).Show();
            //this.Close();
        }

        private void tem4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new Article(fon, s).Show();
            //this.Close();
        }

        private void tem5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new SravPrev(fon, s).Show();
            //this.Close();
        }

        private void tem6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new MuchMany(fon, s).Show();
            //this.Close();
        }

        private void tem7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new Chisl(fon, s).Show();
            //this.Close();
        }

        private void tem8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new Mnozh(fon, s).Show();
            //this.Close();
        }

        private void tem9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new SomeAny(fon, s).Show();
            //this.Close();
        }

        private void tem10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new ThisThat(fon, s).Show();
            //this.Close();
        }

        private void tem11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new ToBe(fon, s).Show();
            //this.Close();
        }

        private void tem12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new PritMest(fon, s).Show();
            //this.Close();
        }

        private void tem13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new PritPadezh(fon, s).Show();
            //this.Close();
        }

        private void tem14_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new HaveGot(fon, s).Show();
            //this.Close();
        }

        private void tem15_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new ThereIsThereAre(fon, s).Show();
            //this.Close();
        }

        private void tem16_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new HaveTo(fon, s).Show();
            //this.Close();
        }

        private void tem19_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new Guestion(fon, s).Show();
            //this.Close();
        }

        private void newbg_Click(object sender, RoutedEventArgs e)
        {
            bg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#ffff00";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#ffff00";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            //img = "/img/голос желтый.png";
            //PropertyChanged(this, new PropertyChangedEventArgs("img"));
            fon = 1;
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            //img = "/img/голос синий.png";
            //PropertyChanged(this, new PropertyChangedEventArgs("img"));
            fon = 2;
        }

        private void newsz_Click(object sender, RoutedEventArgs e)
        {
            s -= 2;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
        }

        private void newsz2_Click(object sender, RoutedEventArgs e)
        {
            s += 2;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
        }

        private void oldbg_Click(object sender, RoutedEventArgs e)
        {
            bg = "#FFFFFF";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#FFFF8000";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            //img = "/img/голос.png";
            //PropertyChanged(this, new PropertyChangedEventArgs("img"));
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            fon = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}

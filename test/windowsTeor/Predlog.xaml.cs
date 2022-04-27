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
using test.windowsTask;

namespace test.windowsTeor
{
    /// <summary>
    /// Логика взаимодействия для Predlog.xaml
    /// </summary>
    public partial class Predlog : Window, INotifyPropertyChanged   
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string vs { get; set; }
        public string bg { get; set; }
        public string fg { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string img3 { get; set; }
        public string img4 { get; set; }
        public string img5 { get; set; }
        public string img6 { get; set; }
        public string img7 { get; set; }
        public string img8 { get; set; }
        public int s { get; set; }
        int f;
        public Predlog(int fon, int sz)
        {
            InitializeComponent();
            s = sz;
            f = fon;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            vib.SelectedIndex = 0;
            if(fon == 0)
            {
                fg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                img1 = "/img/in.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img1"));
                img2 = "/img/on.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img2"));
                img3 = "/img/under.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img3"));
                img4 = "/img/next to.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img4"));
                img5 = "/img/in front of.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img5"));
                img6 = "/img/behind.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img6"));
                img7 = "/img/opposite.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img7"));
                img8 = "/img/between.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img8"));
            }
            else if(fon==1)
            {
                bg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                img1 = "/img/inЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img1"));
                img2 = "/img/onЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img2"));
                img3 = "/img/underЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img3"));
                img4 = "/img/next toЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img4"));
                img5 = "/img/in front ofЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img5"));
                img6 = "/img/behindЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img6"));
                img7 = "/img/oppositeЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img7"));
                img8 = "/img/betweenЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img8"));
            }
            else if(fon==2)
            {
                bg = "#99ccff";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                img1 = "/img/inС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img1"));
                img2 = "/img/onС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img2"));
                img3 = "/img/underС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img3"));
                img4 = "/img/next toС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img4"));
                img5 = "/img/in front ofС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img5"));
                img6 = "/img/behindС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img6"));
                img7 = "/img/oppositeС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img7"));
                img8 = "/img/betweenС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img8"));
            }
            switch(vib.SelectedIndex)
            {
                case 0:
                    vs = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs"));
                    break;
                case 1:
                    vs = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs"));
                    break;
                case 2:
                    vs = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs"));
                    break;
            }
        }

        private void Chack_Click(object sender, RoutedEventArgs e)
        {
            new Start().Show();
            this.Close();
        }

        private void newbg_Click(object sender, RoutedEventArgs e)
        {
            bg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            fg = "#ffff00";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            img1 = "/img/inЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img1"));
            img2 = "/img/onЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img2"));
            img3 = "/img/underЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img3"));
            img4 = "/img/next toЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img4"));
            img5 = "/img/in front ofЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img5"));
            img6 = "/img/behindЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img6"));
            img7 = "/img/oppositeЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img7"));
            img8 = "/img/betweenЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img8"));
            f = 1;
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            fg = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            img1 = "/img/inС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img1"));
            img2 = "/img/onС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img2"));
            img3 = "/img/underС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img3"));
            img4 = "/img/next toС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img4"));
            img5 = "/img/in front ofС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img5"));
            img6 = "/img/behindС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img6"));
            img7 = "/img/oppositeС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img7"));
            img8 = "/img/betweenС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img8"));
            f = 2;
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
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            img1 = "/img/in.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img1"));
            img2 = "/img/on.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img2"));
            img3 = "/img/under.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img3"));
            img4 = "/img/next to.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img4"));
            img5 = "/img/in front of.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img5"));
            img6 = "/img/behind.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img6"));
            img7 = "/img/opposite.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img7"));
            img8 = "/img/between.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img8"));
            f = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new PredlogTask(f, s).Show();
            this.Close();
        }
    }
}

﻿using System;
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
    /// Логика взаимодействия для SravPrev.xaml
    /// </summary>
    public partial class SravPrev : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string vs1 { get; set; }
        public string vs2 { get; set; }
        public string vs3 { get; set; }
        public int s { get; set; }
        int f;
        public SravPrev(int fon, int sz)
        {
            InitializeComponent();
            s = sz;
            f = fon;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            vib.SelectedIndex = 0;
           
        }

        private void Chack_Click(object sender, RoutedEventArgs e)
        {
            new Start().Show();
            this.Close();
        }

        private void newbg_Click(object sender, RoutedEventArgs e)
        {
            f = 1;
            new SravPrev2(f, s).Show();
            this.Close();
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            f = 2;
            new SravPrev2(f, s).Show();
            this.Close();
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
            f = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new SravPrevTask(f, s).Show();
            this.Close();
        }

        private void vib_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (vib.SelectedIndex)
            {
                case 0:
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    break;
                case 1:
                    vs1 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    break;
                case 2:
                    vs2 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    break;
                case 3:
                    vs3 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    break;
            }
        }
    }
}

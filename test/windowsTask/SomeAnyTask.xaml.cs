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
using test.windowsCheck;
using test.windowsTeor;

namespace test.windowsTask
{
    /// <summary>
    /// Логика взаимодействия для SomeAnyTask.xaml
    /// </summary>
    public partial class SomeAnyTask : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int f;
        public SomeAnyTask(int fon, int sz)
        {
            InitializeComponent();
            s = sz;
            f = fon;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            if (fon == 0)
            {
                fg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                bb = "#FFFF8000";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            }
            else if (fon == 1)
            {
                bg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                bb = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            }
            else if (fon == 2)
            {
                bg = "#99ccff";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                bb = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
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
            bb = "#ffff00";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#ffff00";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            f = 1;
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
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
            bb = "#FFFF8000";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            f = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new SomeAny(f, s).Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (z2v1.IsChecked == true && z2v4.IsChecked == true && z2v6.IsChecked == true && z2v7.IsChecked == true && z2v0.IsChecked == true && z2v12.IsChecked == true && z2v14.IsChecked == true && z2v16.IsChecked == true && z2v17.IsChecked == true && z2v20.IsChecked == true)
                {
                    new Right(f, s).ShowDialog();
                }
                else
                {
                    new SAny(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                if (z3v1.Text == "any" && z3v2.Text == "some" && z3v3.Text == "some" && z3v4.Text == "any" && z3v5.Text == "any")
                {
                    new Right(f, s).ShowDialog();
                }
                else
                {
                    new SAny(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (vib1.SelectedIndex == 0 && vib2.SelectedIndex == 1 && vib3.SelectedIndex == 1 && vib4.SelectedIndex == 0)
                {
                    new Right(f, s).ShowDialog();
                }
                else
                {
                    new SAny(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
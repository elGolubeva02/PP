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
    /// Логика взаимодействия для ToBeTask.xaml
    /// </summary>
    public partial class ToBeTask : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int f;
        public ToBeTask(int fon, int sz)
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
            new ToBe(f, s).Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                if (z3v1.Text == "am" && z3v2.Text == "is" && z3v3.Text == "are" && z3v4.Text == "is" && z3v5.Text == "are" && z3v6.Text == "am" && z3v7.Text == "are" && z3v8.Text == "is" && z3v9.Text == "is" && z3v10.Text == "is" && z3v11.Text == "is" && z3v12.Text == "are" && z3v13.Text == "am" && z3v14.Text == "is" && z3v15.Text == "is")
                {
                    new Right(f, s).ShowDialog();
                }
                else
                {
                    new Be(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
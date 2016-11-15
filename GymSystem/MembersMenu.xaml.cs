﻿using System;
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
using System.Windows.Shapes;

namespace GymSystem
{
    /// <summary>
    /// Interaction logic for MembersMenu.xaml
    /// </summary>
    public partial class MembersMenu : Window
    {
        public MembersMenu()
        {
            InitializeComponent();
            splashScreen sp = new splashScreen();
            canvasPanel.Children.Add(sp);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            canvasPanel.Children.Clear();
            UCmembersTimeTable memTT = new UCmembersTimeTable();
            canvasPanel.Children.Add(memTT);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            canvasPanel.Children.Clear();
            UCbmi bmi = new UCbmi();
            canvasPanel.Children.Add(bmi);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace _27_12_2022_WPF_Calculator_Fishman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "2";
        }

        private void thre_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            TextBox2.Text = TextBox2.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "7";
        }

        private void eith_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            TextBox2.Text = TextBox2.Text + "0";
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
           // string textb2 = TextBox2.Text.Length()

       
           // TextBox2.Text = TextBox2.Text + ".";
        }

        private void equ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox2.Clear();
        }
    }
}

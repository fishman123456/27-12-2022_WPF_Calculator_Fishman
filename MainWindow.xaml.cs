using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        bool point_clik = false;
        string _one = "0";
        string _two = "0";
        double result = 0;
        string znak = "!";
        public MainWindow()
        {
            InitializeComponent();
        }
        //private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        //{
        //    TextBox1.Text += e.Key.ToString();
        //}
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox2.Text = Regex.Replace(TextBox2.Text, "[^0-9 ,]+", "");
        }

        private void TexBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0" )
            {
                TextBox2.Clear();
         
            }
            if (znak=="!" && TextBox1.Text != "")
            {
                 TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {

            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
           //     TextBox1.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "2";
        }

        private void thre_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
             //   TextBox1.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
               // TextBox1.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
               // TextBox1.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
                //TextBox1.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
                //TextBox1.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "7";
        }

        private void eith_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
               // TextBox1.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
               TextBox2.Clear();
                //TextBox1.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
          
            TextBox2.Text = TextBox2.Text + "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "0")
            {
                TextBox2.Clear();
            }
            if (znak == "!" && TextBox1.Text != "")
            {
                TextBox1.Clear();
                result = 0;
            }
            TextBox2.Text = TextBox2.Text + "0";
        }
        private void point_Click(object sender, RoutedEventArgs e)
        {
            // string textb2 = TextBox2.Text.Length()

            if ((!point_clik) && !TextBox2.Text.Contains(','))
            {
                TextBox2.Text += ",";
                point_clik = true;
            }
        }
        private void equ_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                _one = result.ToString();
                // TextBox1.Clear();
                _two = TextBox2.Text.ToString();
            }
            if (TextBox2.Text != "0")
            {
                _two = TextBox2.Text;
                TextBox1.Text += _two;
            }

            if (znak == "+")
            {
                result = Convert.ToDouble(_one) + Convert.ToDouble(_two);
            }
            if (znak == "-")
            {
                result = Convert.ToDouble(_one) - Convert.ToDouble(_two);
            }
            if (znak == "*")
            {
                result = Convert.ToDouble(_one) * Convert.ToDouble(_two);
            }
            if (znak == "/")
            {
                result = Convert.ToDouble(_one) / Convert.ToDouble(_two);
            }
            //string result2=result.ToString();
            TextBox1.Clear();
            TextBox1.Text = TextBox1.Text + result.ToString();
            TextBox2.Clear();
            znak = "";
        }


        private void clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox2.Text = "0";
            point_clik = false;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text.Length > 0)
            {
                TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1);
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            _one = TextBox2.Text;
            if (!TextBox1.Text.Contains('+'))
            {
                znak= "+";
                TextBox1.Text +=TextBox2.Text + "+";
                point_clik = false;
            }
            TextBox2.Text="";
        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            _one = TextBox2.Text;
            if (!TextBox1.Text.Contains('-'))
            {
                znak = "-";
                TextBox1.Text += TextBox2.Text + "-";
                point_clik = false;
            }
            TextBox2.Clear();
        }
        private void multi_Click(object sender, RoutedEventArgs e)
        {
            _one = TextBox2.Text;
            if (!TextBox1.Text.Contains('*'))
            {
                znak = "*";
                TextBox1.Text += TextBox2.Text + "*";
                point_clik = false;
            }
            TextBox2.Clear();
        }
        private void delim_Click(object sender, RoutedEventArgs e)
        {
            _one = TextBox2.Text;
            if (!TextBox1.Text.Contains('/'))
            {
                znak = "/";
                TextBox1.Text += TextBox2.Text + "/";
                point_clik = false;
            }
            TextBox2.Clear();
        }
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            point_clik = false;
            TextBox1.Text = "";
            TextBox2.Text = "0";
            _one = "0";
            _two = "0";
            result = 0;
        }

       
    }
}

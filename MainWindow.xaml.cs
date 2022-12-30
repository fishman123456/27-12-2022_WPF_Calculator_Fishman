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
        bool point_clik = false;
        char last_char = ' ';
        string _one = "";
        string _two = "";
        int result;
        string znak = "";
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TexBox1_TextChanged(object sender, TextChangedEventArgs e)
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
            if (TextBox2.Text == "")
            {
                TextBox2.Text = "0";
            }
            if (!point_clik)
            {
                TextBox2.Text = TextBox2.Text + ".";
                point_clik = true;
            }  
        }

        private void equ_Click(object sender, RoutedEventArgs e)
        {
            if (result!=0)
            {
                _one = result.ToString();
                TextBox1.Clear();
            }
             _two = TextBox2.Text;
            TextBox1.Text += _two;
            if (znak == "+")
            {
                 result = Convert.ToInt32(_one) + Convert.ToInt32(_two);
            }
            if (znak == "-")
            {
                 result = Convert.ToInt32(_one) - Convert.ToInt32(_two);
            }
            if (znak == "*")
            {
                 result = Convert.ToInt32(_one) * Convert.ToInt32(_two);
            }
            if (znak == "/")
            {
                 result = Convert.ToInt32(_one) / Convert.ToInt32(_two);
            }
            //string result2=result.ToString();
            TextBox1.Clear();
            TextBox1.Text = TextBox1.Text+ result.ToString();
            TextBox2.Clear();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox2.Clear();
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
            TextBox1.Text += _one+"+";
            znak = "+";
            point_clik = false;
            TextBox2.Clear();
        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            _one = TextBox2.Text;
            TextBox1.Text += _one + "-";
            znak = "-";
            point_clik = false;
            TextBox2.Clear();
        }
        private void multi_Click(object sender, RoutedEventArgs e)
        {
            _one = TextBox2.Text;
            TextBox1.Text += _one + "*";
            znak = "*";
            point_clik = false;
            TextBox2.Clear();
        }
        private void delim_Click(object sender, RoutedEventArgs e)
        {
            _one = TextBox2.Text;
            TextBox1.Text += _one + "/";
            znak = "/";
            point_clik = false;
            TextBox2.Clear();
        }
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            point_clik = false;
            TextBox1.Clear();
            TextBox2.Clear();
            _one = "";
            _two = "";

        }

        




        //public string ProvLastChar(char j) // функция проверки на второй знак действия + - * /
        //{
        //    char[] chars = TextBox2.Text.ToCharArray();
        //    int numLastChar = chars.Length;
        //    try
        //    {
        //        char last_char = chars[numLastChar - 1];
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Введите число");
        //        TextBox2.Text.DefaultIfEmpty();

        //    }

        //    if (last_char != '+' && last_char != '-' && last_char != '/' && last_char != '*')
        //    {
        //        return TextBox2.Text += j;
        //    }
        //    else
        //    {
        //        return TextBox2.Text;
        //    }

        //}




    }
}

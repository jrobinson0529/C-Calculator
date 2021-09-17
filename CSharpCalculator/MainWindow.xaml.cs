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

namespace CSharpCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _num1;
        private int _num2;
        private int _operation;
        private int _solution;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "1";
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "2";
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "3";
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "4";
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "5";
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "6";
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "7";
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "8";
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "9";
        }
        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
        }
        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            _num1 = 0;
            _num2 = 0;
            _solution = 0;
            txtResult.Text = "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

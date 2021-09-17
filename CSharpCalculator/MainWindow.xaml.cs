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
        private long _num1;
        private long _num2;
        private char _operatorCharacter;
        private bool _operatorChosen = false;
        private long _solution;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Operation()
        {
            switch(_operatorCharacter)
            {
                case '+':
                    _solution = _num1 + _num2;
                    break;
                case '-':
                    _solution = _num1 - _num2;
                    break;
                case '*':
                    _solution = _num1 * _num2;
                    break;
                case '/':
                    _solution = _num1 / _num2;
                    break;
                default:
                    break;
            }
                
        }
        private void Clear()
        {
            _num1 = 0;
            _num2 = 0;
            _solution = 0;
            _operatorCharacter = '?';
            _operatorChosen = false;
            txtResult.Text = "0";
        }
        private void Clear(string textBoxDisplay)
        {
            _num1 = 0;
            _num2 = 0;
            _solution = 0;
            _operatorCharacter = '?';
            _operatorChosen = false;
            txtResult.Text = textBoxDisplay;
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            long a;
            if(_operatorChosen)
            {
                a = _num2;
            } else
            {
                a = _num1;
            }
            
            var b = 1;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 2;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 3;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 4;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 5;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 6;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 7;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 8;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 9;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            long a;
            if (_operatorChosen)
            {
                a = _num2;
            }
            else
            {
                a = _num1;
            }

            var b = 0;
            var newNumber = int.Parse(a.ToString() + b.ToString());
            txtResult.Text = newNumber.ToString();
            if (_operatorChosen) { _num2 = newNumber; } else { _num1 = newNumber; }
        }
        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        private void Button_ClickAddition(object sender, RoutedEventArgs e)
        {
            
            _operatorCharacter = '+';
            txtResult.Text = _operatorCharacter.ToString();
            _operatorChosen = true;
        }
        private void Button_ClickSubtraction(object sender, RoutedEventArgs e)
        {
            _operatorCharacter = '-';
            txtResult.Text = _operatorCharacter.ToString();
            _operatorChosen = true;
        }
        private void Button_ClickMultiplication(object sender, RoutedEventArgs e)
        {
            _operatorCharacter = '*';
            txtResult.Text = _operatorCharacter.ToString();
            _operatorChosen = true;
        }
        private void Button_ClickDivision(object sender, RoutedEventArgs e)
        {
            _operatorCharacter = '/';
            txtResult.Text = _operatorCharacter.ToString();
            _operatorChosen = true;
        }
        private void Button_ClickSolution(object sender, RoutedEventArgs e)
        {
            Operation();
            _num1 = _solution;
            _num2 = 0;
            txtResult.Text = _solution.ToString();
        }
    }
}

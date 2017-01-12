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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner
{

    public partial class MainWindow : Window
    {
        private string LeftOperand;
        private string Operator;
        private string RightOperand;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {

            if (Operator == null)
            {
                LeftOperand += "7";
                Display.Text = LeftOperand;
            }

            else
            {
                RightOperand += "7";
                Display.Text = RightOperand;
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "8";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "8";
                Display.Text = RightOperand;
            }
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "9";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "9";
                Display.Text = RightOperand;
            }
        }

        private void SlashButton_Click(object sender, RoutedEventArgs e)
        {
            Operator = "/";
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "4";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "4";
                Display.Text = RightOperand;
            }
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "5";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "5";
                Display.Text = RightOperand;
            }
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "6";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "6";
                Display.Text = RightOperand;
            }
        }

        private void TimesButton_Click(object sender, RoutedEventArgs e)
        {
            Operator = "*";
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "1";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "1";
                Display.Text = RightOperand;
            }
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "2";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "2";
                Display.Text = RightOperand;
            }
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "3";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "3";
                Display.Text = RightOperand;
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            Operator = "-";
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += "0";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += "0";
                Display.Text = RightOperand;
            }
        }

        private void CommaButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                LeftOperand += ",";
                Display.Text = LeftOperand;
            }
            else
            {
                RightOperand += ",";
                Display.Text = RightOperand;
            }
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double left = Convert.ToDouble(LeftOperand);
                double right = Convert.ToDouble(RightOperand);
                switch (Operator)
                {
                    case "+":
                        Display.Text = (left + right).ToString();
                        break;
                    case "-":
                        Display.Text = (left - right).ToString();
                        break;
                    case "*":
                        Display.Text = (left * right).ToString();
                        break;
                    case "/":
                        Display.Text = (left / right).ToString();
                        break;
                }
            }
            catch
            {

                Display.Text = "E";
            }

            LeftOperand = null;
            Operator = null;
            RightOperand = null;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            Operator = "+";
        }
    }
}

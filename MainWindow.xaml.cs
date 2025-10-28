using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace _123
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
            public MainWindow()
            { 
                InitializeComponent();
            }

            private void CalculateButton_Click(object sender, RoutedEventArgs e)
            {
                string input = InputTextBox.Text;

                if (string.IsNullOrEmpty(input))
                {
                    ResultTextBlock.Text = "Ошибка: Введите число!";
                    return;
                }

                long number;
                try
                {
                    number = long.Parse(input);
                }
                catch (FormatException)
                {
                    ResultTextBlock.Text = "Ошибка: Некорректный ввод!";
                    return;
                }

                if (number < 0)
                {
                    ResultTextBlock.Text = "Ошибка: Число должно быть положительным!";
                    return;
                }

                try
                {
                BigInteger factorial = CalculateFactorial(number);
                    ResultTextBlock.Text = $"Факториал: {factorial}";
                }
                catch (OverflowException)
                {
                    ResultTextBlock.Text = "Ошибка: Переполнение!";
                }
            }

            private BigInteger CalculateFactorial(long n)
            {
            BigInteger result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

    }


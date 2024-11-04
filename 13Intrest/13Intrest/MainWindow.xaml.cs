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

namespace _13Intrest
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

        StringBuilder sb = new StringBuilder();

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
            float.TryParse(startCapitalTextBox.Text, out float start);
            float.TryParse(endCapitalTextBox.Text, out float end);
            float.TryParse(intrestTextBox.Text, out float intrestPercentage);
            int year = 0;
            float intrest;

            while (start < end)
            {
                year++;
                intrest = start * intrestPercentage / 100;
                start = start + intrest;
                sb.AppendLine($"Waarde na {year} jaren: € {start:f2}");
            }

            resultTextBox.Text = sb.ToString();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            startCapitalTextBox.Clear();
            endCapitalTextBox.Clear();
            intrestTextBox.Clear();
            resultTextBox.Clear();
            startCapitalTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

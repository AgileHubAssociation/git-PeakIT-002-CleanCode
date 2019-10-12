using System;
using System.Windows;

namespace StrategiesForMethods_Demo
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

        private bool AreInputFieldsMissing()
        {
            return string.IsNullOrEmpty(txtFirstNumber.Text)
                    || string.IsNullOrEmpty(txtSecondNumber.Text);
        }
        private void btnAddNumbers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AreInputFieldsMissing())
                {
                    throw new Exception("You must specify a value for the input numbers");
                }
                
                textBlockSum.Text = ComputeSum().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private int ComputeSum()
        {
            int firstNumber = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(txtSecondNumber.Text);

            int sum = firstNumber + secondNumber;
            return sum;
        }
    }
}

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

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FillComboBoxes();
        }

       private void FillComboBoxes()
        {
            CmBoxIn.Items.Add("USD");
            CmBoxIn.Items.Add("EUR");
            CmBoxIn.Items.Add("BGN");
            CmBoxIn.Items.Add("GBP");

            CmBoxOut.Items.Add("USD");
            CmBoxOut.Items.Add("EUR");
            CmBoxOut.Items.Add("BGN");
            CmBoxOut.Items.Add("GBP");
        }

        private void getResults(double amount)
        {
            txtOutput.Text = Math.Truncate(amount).ToString();
            txtChange.Text = String.Format("{0:0.00}", Calculations.CHANGE);
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double isDouble = 0.0;

            if ((double.TryParse(txtInput.Text.ToString(), out isDouble)) == true)
            {
                if (CmBoxIn.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a currency to convert!");
                }
                else if (CmBoxOut.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a converted currency!");
                }
                else
                {
                    getResults(Calculations.getCurrency(Double.Parse(txtInput.Text), CmBoxIn.Text.ToString(), CmBoxOut.Text.ToString()));
                }
            }
        }

        private void CmBoxIn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtChange.Clear();

        }
    }
}

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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SendOrder_Click(object sender, RoutedEventArgs e)
        {
            string selectedSymbol = ((ComboBoxItem)SymbolComboBox.SelectedItem).Content.ToString();
            string selectedSide = ((ComboBoxItem)SideComboBox.SelectedItem).Content.ToString();
            int qty = 0;

            if (int.TryParse(QtyTextBox.Text, out qty))
            {
                PlaceOrder(selectedSymbol, selectedSide, qty);

                LogsTextBlock.Text += $"Order placed - Symbol: {selectedSymbol}, Side: {selectedSide}, Qty: {qty}\n";
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }

        private void PlaceOrder(string symbol, string side, int quantity)
        {
            //Code to place the order
        }
    }
}

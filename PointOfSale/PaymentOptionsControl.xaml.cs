using GyroScope.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptionsControl.xaml
    /// </summary>
    public partial class PaymentOptionsControl : UserControl
    {
        public PaymentOptionsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for "Cash" button click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for "Debit" button click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e"></param>
        private void debitButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            double total = (double)order.Total;
            if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.Approved)
            {
                //print recipt
                Order newOrder = new Order();
            }

            else if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.Declined) 
            {
                MessageBox.Show("This card is declined");
                //try a different card
            }

            else if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.ReadError)
            {
                MessageBox.Show("This card has a read error");
                //have them swipe card again
            }

            else if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("This card has insufficient funds");
            }

            else if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("This card's pin is incorrect");
                //if there was a correct pin enum test again
            }


        }

        /// <summary>
        /// Event handler for "Credit" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void creditButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

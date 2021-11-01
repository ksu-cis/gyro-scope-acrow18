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
        /// Checks the type of payment
        /// </summary>
        /// <param name="sender">sender</param>
        /// <returns>Type of payment</returns>
        public string TypeOfPayment(object sender)
        {
            if (sender is Button button)
            {
                if (button.Content.ToString() == "Cash")
                {
                    return "Cash";
                }

                if (button.Content.ToString() == "Credit")
                {
                    return "Credit";
                }

                if (button.Content.ToString() == "Debit")
                {
                    return "Cash";
                }
            }

            return "Payment doesn't exist";
        }

        /// <summary>
        /// Finds the main window
        /// </summary>
        /// <returns>A main window</returns>
        public MainWindow FindMainWindow()
        {

            DependencyObject parent = this;

            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }

            while (!(parent is null || parent is MainWindow));
            MainWindow mainWindow = (MainWindow)parent;
            return mainWindow;
        }

        /// <summary>
        /// Event handler for "Cash" button click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void CashButton_Click(object sender, RoutedEventArgs e)
        {
            dynamic customization;
            MainWindow mainWindow = FindMainWindow();
            customization = new CashPaymentProcessing();
            mainWindow.menuItemSelection.Child = customization;
        }

        /// <summary>
        /// Event handler for "Debit" button click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void DebitAndCreditButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = FindMainWindow();
            double total = (double)mainWindow.Order.Total;
            if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.Approved)
            {
                //print recipt
                Order newOrder = new Order();
            }

            else if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.Declined)
            {
                MessageBox.Show("This card is declined.");
                //try a different card
            }

            else if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.ReadError)
            {
                MessageBox.Show("This card has a read error.");
                //have them swipe card again
            }

            else if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("This card has insufficient funds.");
            }

            else if (RoundRegister.CardReader.RunCard(total) == RoundRegister.CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("This card's pin is incorrect.");
                //if there was a correct pin enum test again
            }

            else 
            {
                MessageBox.Show("This is an invalid transaction.");
            }
        }
    }
}

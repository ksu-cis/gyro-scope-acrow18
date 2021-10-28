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

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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes label of Order summary
        /// </summary>
        public void ChangeLabels() 
        {
            Order<IMenuItem> order = new Order<IMenuItem>();
            orderNumber.Content = "Order #" + $"{order.Number}";
            dateOfOrderPlaced.Content = order.PlacedAt;
            subtotalLabel.Content = "$ " + $"{order.Subtotal}";
            taxLabel.Content = "$ " + $"{order.Tax}";
            totalLabel.Content = "$ " + $"{order.Total}";
        }

    }
}

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
    /// Interaction logic for CardPaymentProcessing.xaml
    /// </summary>
    public partial class CashPaymentProcessing : UserControl
    {
        public CashPaymentProcessing()
        {
            InitializeComponent();
            this.DataContext = new RegisterViewModel(Order);
        }

        /// <summary>
        /// Initializes a order.
        /// </summary>
        public Order _order = new Order();

        /// <summary>
        /// Sets the order property.
        /// </summary>
        public Order Order
        {
            get => _order;
            set
            {
                if (_order != value)
                {
                    _order = value;
                    DataContext = value;
                }
            }
        }


        /// <summary>
        /// Event handler for "Return to Order" click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            dynamic customization;
            MainWindow mainWindow = FindMainWindow();
            customization = new MenuItemSelectionControl();
            mainWindow.menuItemSelection.Child = customization;
        }

        /// <summary>
        /// Event handler for "Finalize Sale" click.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FinalizeSale_Click(object sender, RoutedEventArgs e)
        {

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
    }
}

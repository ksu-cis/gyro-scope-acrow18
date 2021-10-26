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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Order();
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
        /// Event handler for "Cancel Order" click.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            menuItemSelection.Child = new MenuItemSelectionControl();
            Order = new Order();
        }

        /// <summary>
        /// Event handler for "Select Items" click.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void SelectItems_Click(object sender, RoutedEventArgs e) 
        {
            menuItemSelection.Child = new MenuItemSelectionControl();
            Order = new Order();
        }

        /// <summary>
        /// Event handler for "Complete Order" click.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e) 
        {
            menuItemSelection.Child = new MenuItemSelectionControl();
            Order = new Order();
        }
    }
}

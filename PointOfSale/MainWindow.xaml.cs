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
        }

        

        /// <summary>
        /// Starts new menu item control 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectItems_Click(object sender, RoutedEventArgs e)
        {
            newMenuItem.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Event handler for "Cancel order" click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelOrder_Click_1(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Content.ToString() == "Cancel Order")
                {
                    menuItem = new MenuItemSelectionControl();
                }
            }
        }
    }
}

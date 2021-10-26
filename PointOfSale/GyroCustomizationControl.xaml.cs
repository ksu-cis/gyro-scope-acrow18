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
    /// Interaction logic for GyroCustomizationControl.xaml
    /// </summary>
    public partial class GyroCustomizationControl : UserControl
    {
        public GyroCustomizationControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes label to represent current Gyro
        /// </summary>
        public void ChangeLabel(object sender) 
        {
            
            MenuItemSelectionControl menuItemSelectionControl = new MenuItemSelectionControl();
            string nameOfbuttonClicked = menuItemSelectionControl.ItemNameOfButtonClicked(sender);

            if (nameOfbuttonClicked == "Virgo Classic Gyro")
            {
                typeOfGyro.Content = "Customize Virgo Classic Gyro";
            }

            else if (nameOfbuttonClicked == "Leo Lamb Gyro")
            {
                typeOfGyro.Content = "Customize Leo Lamb Gyro";
            }

            else if (nameOfbuttonClicked == "Scorpio Spicy Gyro")
            {
                typeOfGyro.Content = "Customize Scorpio Spicy Gyro";
            }

        }
    }
}

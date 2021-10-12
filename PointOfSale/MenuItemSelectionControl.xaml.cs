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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Name of item from button click
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public string ItemNameOfButtonClicked(object sender) 
        {
            if (sender is Button button)
            {
                return button.Content.ToString();
            }

            else 
            {
                throw new InvalidOperationException("Item doesn't exist");
            }
            
        }

        /// <summary>
        /// Switches to correct menu item
        /// </summary>
        /// <param name="name">Name of menu item</param>
        /// <param name="sender"></param>
        public void SwitchScreen(string name, object sender) 
        {
            name = ItemNameOfButtonClicked(sender);

            switch (name) 
            {
                ///Drinks
                case "Capricorn Mountain Tea":
                    menuSelectionControl.Child = new CapricornMountainTeaControl();
                break;

                case "Libra Libation":
                    menuSelectionControl.Child = new LibraLibation();
                break;

                ///Entrees
                case "Virgo Classic Gyro":
                    menuSelectionControl.Child = new GyroCustomizationControl();
                break;

                case "Leo Lamb Gyro":
                    menuSelectionControl.Child = new GyroCustomizationControl();
                break;

                case "Scorpio Spicy Gyro":
                    menuSelectionControl.Child = new GyroCustomizationControl();
                break;

                case "Pisces Fish Dish":
                    menuSelectionControl.Child = new PiscesFishDishControl();
                break;

                ///Sides
                case "Aries Fries":
                    menuSelectionControl.Child = new SidesControl();
                break;

                case "Gemini Stuffed Grape Leaves":
                    menuSelectionControl.Child = new SidesControl();
                break;

                case "Sagittarius Greek Salad":
                    menuSelectionControl.Child = new SidesControl();
                break;

                case "Taurus Tabuleh":
                    menuSelectionControl.Child = new SidesControl();
                break;

                ///Treats
                case "Aquarius Ice":
                    menuSelectionControl.Child = new AquariusIceControl();
                break;

                case "Cancer Halva Cake":
                    menuSelectionControl.Child = new CancerHalvaCakeControl();
                break;
            }
        }
    }
}

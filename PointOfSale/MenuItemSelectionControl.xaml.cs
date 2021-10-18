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
using GyroScope.Data.Drinks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Treats;
using GyroScope.Data.Sides;

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
        /// <param name="sender">Sender</param>
        /// <returns>Content on button</returns>
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
        /// <param name="sender">Sender</param>
        public void SwitchScreen(string name) 
        {
            ///not a var because vars need to be set to something
            dynamic customization;

            switch (name) 
            {
                ///Drinks
                case "Capricorn Mountain Tea":
                    customization = new CapricornMountainTeaControl();
                    MenuSelectionControl.Child = customization;
                    CapricornMountainTea capricornMountainTea = new CapricornMountainTea();
                    customization.DataContext = capricornMountainTea; 
                break;

                case "Libra Libation":
                    customization = new LibraLibation();
                    MenuSelectionControl.Child = customization;
                    LibraLibation libraLibation = new LibraLibation();
                    customization.DataContext = libraLibation;
                break;

                ///Entrees
                case "Virgo Classic Gyro":
                    customization = new GyroCustomizationControl();
                    MenuSelectionControl.Child = customization;
                    VirgoClassicGyro virgoClassicGyro = new VirgoClassicGyro();
                    customization.DataContext = virgoClassicGyro;
                break;

                case "Leo Lamb Gyro":
                    customization = new GyroCustomizationControl();
                    MenuSelectionControl.Child = customization;
                    LeoLambGyro leoLambGyro = new LeoLambGyro();
                    customization.DataContext = leoLambGyro;
                break;

                case "Scorpio Spicy Gyro":
                    customization = new GyroCustomizationControl();
                    MenuSelectionControl.Child = customization;
                    ScorpioSpicyGyro scorpioSpicyGyro = new ScorpioSpicyGyro();
                    customization.DataContext = scorpioSpicyGyro;
                break;

                case "Pisces Fish Dish":
                    customization = new PiscesFishDishControl();
                    MenuSelectionControl.Child = customization;
                    PiscesFishDish piscesFishDish = new PiscesFishDish();
                    customization.DataContext = piscesFishDish;
                break;

                ///Sides
                case "Aries Fries":
                    customization = new SidesControl();
                    MenuSelectionControl.Child = customization;
                    AriesFries ariesFries = new AriesFries();
                    customization.DataContext = ariesFries;
                break;

                case "Gemini Stuffed Grape Leaves":
                    customization = new SidesControl();
                    MenuSelectionControl.Child = customization;
                    GeminiStuffedGrapeLeaves geminiStuffedGrapeLeaves = new GeminiStuffedGrapeLeaves();
                    customization.DataContext = geminiStuffedGrapeLeaves;
                break;

                case "Sagittarius Greek Salad":
                    customization = new SidesControl();
                    MenuSelectionControl.Child = customization;
                    SagittariusGreekSalad sagittariusGreekSalad = new SagittariusGreekSalad();
                    customization.DataContext = sagittariusGreekSalad;
                break;

                case "Taurus Tabuleh":
                    customization = new SidesControl();
                    MenuSelectionControl.Child = customization;
                    TaurusTabuleh taurusTabuleh = new TaurusTabuleh();
                    customization.DataContext = taurusTabuleh;
                break;

                ///Treats
                case "Aquarius Ice":
                    customization = new AquariusIceControl();
                    MenuSelectionControl.Child = customization;
                    AquariusIce aquariusIce = new AquariusIce();
                    customization.DataContext = aquariusIce;
                break;

                case "Cancer Halva Cake":
                    customization = new CancerHalvaCakeControl();
                    MenuSelectionControl.Child = customization;
                    CancerHalvaCake cancerHalvaCake = new CancerHalvaCake();
                    customization.DataContext = cancerHalvaCake;
                break;
            }
        }

        /// <summary>
        /// Used to switch screens
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">e</param>
        private void MenuSelectionControl_Click(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button)
            {
                SwitchScreen(button.Content.ToString());
                e.Handled = true;
            }
        }
    }
}

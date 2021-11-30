/*
 * Menu.cs
 * Author: ALisha C.
 */

using GyroScope.Data.Drinks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Enums;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GyroScope.Data
{
    /// <summary>
    /// Static class for the menu items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets a list of the entrees
        /// </summary>
        public static IEnumerable<IMenuItem> Entrees
        {
            get
            {
                var entrees = new List<IMenuItem>();
                entrees.Add(new VirgoClassicGyro());
                entrees.Add(new LeoLambGyro());
                entrees.Add(new ScorpioSpicyGyro());
                entrees.Add(new PiscesFishDish());
                return entrees;
            }
        }

        /// <summary>
        /// Gets a list of the sides
        /// </summary>
        public static IEnumerable<IMenuItem> Sides
        {
            //change foreach
            get
            {
                var sides = new List<IMenuItem>();
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    sides.Add(new AriesFries() { Size = size });
                    sides.Add(new GeminiStuffedGrapeLeaves() { Size = size });
                    sides.Add(new SagittariusGreekSalad() { Size = size });
                    sides.Add(new TaurusTabuleh() { Size = size });
                }

                return sides;
            }
        }

        /// <summary>
        /// Gets a list of drinks 
        /// </summary>
        public static IEnumerable<IMenuItem> Drinks
        {
            //change foreach
            get
            {
                var drinks = new List<IMenuItem>();
                LibraLibation libraLibation = new LibraLibation();

                drinks.Add(new CapricornMountainTea());

                foreach (LibraLibationFlavor flavor in Enum.GetValues(typeof(LibraLibationFlavor)))
                {

                    drinks.Add(new LibraLibation() { Sparkling = libraLibation.Sparkling, Flavor = flavor });
                }

                return drinks;
            }
        }

        /// <summary>
        /// Gets a list of treats
        /// </summary>
        public static IEnumerable<IMenuItem> Treats
        {
            get
            {

                var treats = new List<IMenuItem>();

                treats.Add(new CancerHalvaCake());

                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    foreach (AquariusIceFlavor flavor in Enum.GetValues(typeof(AquariusIceFlavor)))
                    {

                        treats.Add(new AquariusIce() { Size = size, Flavor = flavor });
                    }
                }

                return treats;
            }
        }

        /// <summary>
        /// Gets a full menu list of all gyro scope options
        /// </summary>
        public static IEnumerable<IMenuItem> FullMenu
        {
            get
            {
                List<IMenuItem> myList = new List<IMenuItem>();
                myList.Add(new VirgoClassicGyro());
                myList.Add(new LeoLambGyro());
                myList.Add(new ScorpioSpicyGyro());
                myList.Add(new PiscesFishDish());
                myList.Add(new AriesFries());
                myList.Add(new GeminiStuffedGrapeLeaves());
                myList.Add(new SagittariusGreekSalad());
                myList.Add(new TaurusTabuleh());
                myList.Add(new CapricornMountainTea());
                myList.Add(new LibraLibation());
                myList.Add(new CancerHalvaCake());
                myList.Add(new AquariusIce());
                return myList;
            }
        }

        /// <summary>
        /// Entire menu
        /// </summary>
        public static IEnumerable<IMenuItem> EntireMenu { get { return FullMenu; } }

        /// <summary>
        /// Searches movies in database
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>The results of the search</returns>
        public static IEnumerable<IMenuItem> Search(string terms)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            //null check
            if (terms == null) return EntireMenu;

            //Add menu item if the name is a match
            foreach (IMenuItem menuItem in EntireMenu)
            {
                foreach (string term in terms.Split(' '))
                {
                    if (menuItem.Name != null && menuItem.Name.Contains(term))
                    {
                        results.Add(menuItem);
                        break;
                    }
                }

                foreach (string term in terms.Split(' '))
                {
                    if (menuItem.Description != null && menuItem.Description.Contains(term))
                    {
                        results.Add(menuItem);
                        break;
                    }
                }
            }

            return results;
        }
    }

    /*
    /// <summary>
    /// Filters by calories
    /// </summary>
    /// <param name="menu">Entire menu</param>
    /// <param name="min">Min calories</param>
    /// <param name="max">Max calories</param>
    /// <returns></returns>
    public static IEnumerable<IMenuItem> FilterByCalories(IEnumerable<IMenuItem> menu, double? min, double? max)
    {
        if (min == null && max == null)
        {
            return menu;
        }

        var results = new List<IMenuItem>();

        // only a maximum specified
        if (min == null)
        {
            foreach (IMenuItem menuItem in menu)
            {
                if (menuItem.Calories <= max)
                {
                    results.Add(menuItem);
                }
            }

            return results;
        }

        // only a minimum specified
        if (max == null)
        {
            foreach (IMenuItem menuItem in menu)
            {
                if (menuItem.Calories >= min)
                {
                    results.Add(menuItem);
                }
            }

            return results;
        }

        // Both minimum and maximum specified
        foreach (IMenuItem menuItem in menu)
        {
            if (menuItem.Calories >= min && menuItem.Calories <= max)
            {
                results.Add(menuItem);
            }
        }

        return results;
    }


    /// <summary>
    /// Filters by Price
    /// </summary>
    /// <param name="menu">Entire menu</param>
    /// <param name="min">Min price</param>
    /// <param name="max">Max price</param>
    /// <returns></returns>
    public static IEnumerable<IMenuItem> FilterByPrice(IEnumerable<IMenuItem> menu, decimal? min, decimal? max)
    {
        if (min == null && max == null)
        { 
            return menu;
        }

        var results = new List<IMenuItem>();

        // only a maximum specified
        if (min == null)
        {
            foreach (IMenuItem menuItem in menu)
            {
                if (menuItem.Price <= max)
                {
                    results.Add(menuItem);
                }
            }

            return results;
        }

        // only a minimum specified
        if (max == null)
        {
            foreach (IMenuItem menuItem in menu)
            {
                if (menuItem.Price >= min)
                {
                    results.Add(menuItem);
                }
            }

            return results;
        }

        // Both minimum and maximum specified
        foreach (IMenuItem menuItem in menu)
        {
            if (menuItem.Price >= min && menuItem.Price <= max)
            {
                results.Add(menuItem);
            }
        }

        return results;
    }
    */
}


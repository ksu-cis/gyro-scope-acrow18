﻿using GyroScope.Data;
using GyroScope.Data.Drinks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using System.Windows;
using System.Windows.Controls;

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
        /// Accessor for data context 
        /// </summary>
        public Order<IMenuItem> DataContextAccessor => (Order<IMenuItem>)DataContext;

        /// <summary>
        /// Removes item from order
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">e</param>
        /// <param name="index">index of item to remove</param>
        private void RemoveItem_Click(object sender, RoutedEventArgs e, int index) 
        {
            if (sender is Button button) 
            {
                DataContextAccessor.Remove((IMenuItem)button.DataContext, index);
            }
        }

       
        /// <summary>
        /// Traverses the tree until it hits a main window
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">E</param>
        public void EditItem(object sender, RoutedEventArgs e) 
        {
            DependencyObject parent = this;

            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }

            while (!(parent is null) || parent is MainWindow);

            if (parent is MainWindow) 
            {
                MainWindow main = (MainWindow)parent;

                if (orderList.SelectedValue is Gyro) 
                {
                    var customization = new GyroCustomizationControl();
                    customization.DataContext = orderList.SelectedItems;
                    main.newMenuItem.Child = customization;
                }

                if (orderList.SelectedValue is PiscesFishDish)
                {
                    var customization = new PiscesFishDishControl();
                    customization.DataContext = orderList.SelectedItems;
                    main.newMenuItem.Child = customization;
                }

                if (orderList.SelectedValue is Side)
                {
                    var customization = new SidesControl();
                    customization.DataContext = orderList.SelectedItems;
                    main.newMenuItem.Child = customization;
                }

                if (orderList.SelectedValue is LibraLibation)
                {
                    var customization = new LibraLibationControl();
                    customization.DataContext = orderList.SelectedItems;
                    main.newMenuItem.Child = customization;
                }

                if (orderList.SelectedValue is AquariusIce)
                {
                    var customization = new AquariusIceControl();
                    customization.DataContext = orderList.SelectedItems;
                    main.newMenuItem.Child = customization;
                }

                if (orderList.SelectedValue is CancerHalvaCake)
                {
                    var customization = new CancerHalvaCakeControl();
                    customization.DataContext = orderList.SelectedItems;
                    main.newMenuItem.Child = customization;
                }

                if (orderList.SelectedValue is CapricornMountainTea)
                {
                    var customization = new CapricornMountainTeaControl();
                    customization.DataContext = orderList.SelectedItems;
                    main.newMenuItem.Child = customization;
                }
            }
        }
    }
}

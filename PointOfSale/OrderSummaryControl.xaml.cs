using GyroScope.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
            //CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// Changes label of Order summary
        /// </summary>
        public void ChangeLabels() 
        {
            Order<IMenuItem> order = new Order<IMenuItem>();
            orderNumber.Content = "Order #" + $"{order.Number}";
            dateOfOrderPlaced.Content = order.PlacedAt;
            subtotalLabel.Content = "Subtotal: $ " + $"{order.Subtotal}";
            taxLabel.Content = "Tax: $ " + $"{order.Tax}";
            totalLabel.Content = "Total: $ " + $"{order.Total}";
        }

        /*
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("PlacedDate"));
            OnPropertyChanged(new PropertyChangedEventArgs("Number"));

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (Order<IMenuItem> item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (Order<IMenuItem> item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Complete")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("CompleteCount"));
                OnPropertyChanged(new PropertyChangedEventArgs("ImcompleteCount"));
                OnPropertyChanged(new PropertyChangedEventArgs("IncompleteCount"));
            }
        }
        */

    }
}

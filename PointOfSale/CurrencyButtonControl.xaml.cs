using System;
using System.Collections.Generic;
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
    /// Interaction logic for CurrencyButtonControl.xaml
    /// </summary>
    public partial class CurrencyButtonControl : UserControl, INotifyPropertyChanged
    {
        
        /// <summary>
        /// Dependency property representing amount to give as change
        /// </summary>
        public static DependencyProperty OutgoingCountProperty = DependencyProperty.Register("OutgoingCount", typeof(int), typeof(CurrencyButtonControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        /// <summary>
        /// Dependency property representing amount coming from customer
        /// </summary>
        public static DependencyProperty IncomingCountProperty = DependencyProperty.Register("IncomingCount", typeof(int), typeof(CurrencyButtonControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender|FrameworkPropertyMetadataOptions.AffectsMeasure| FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Click event for incoming change
        /// </summary>
        public static readonly RoutedEvent IncomingClickChangeEvent = EventManager.RegisterRoutedEvent("IncomingChangeClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CurrencyButtonControl));

        /// <summary>
        /// Property change event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Number of denomination given back as change.
        /// </summary>
        public int OutgoingCount
        {
            get { return (int)GetValue(OutgoingCountProperty); }
            set 
            { 
                SetValue(OutgoingCountProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OutgoingCount)));
            }
        }

        /// <summary>
        /// Number of denomination being recived by the cashier.
        /// </summary>
        public int IncomingCount
        {
            get { return (int)GetValue(IncomingCountProperty); }
            set 
            { 
                SetValue(IncomingCountProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IncomingCount)));
            }
        }

        /// <summary>
        /// Event handler to change the incoming bill count.
        /// </summary>
        public event RoutedEventHandler IncomingChangeClick 
        {
            add { AddHandler(IncomingClickChangeEvent, value); }
            remove { RemoveHandler(IncomingClickChangeEvent, value); }
        }


        /// <summary>
        /// Handles the even that updates the count of the incoming bills
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        public void HandleIncomingClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button) 
            {
                switch (button.Name) 
                {
                    case "plusButton":
                        IncomingCount++;
                        break;

                    case "minusButton":
                        if(IncomingCount > 0) 
                        IncomingCount--;
                        break;
                }
            }

            e.Handled = true;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CurrencyButtonControl()
        {
            InitializeComponent();
            Button button = new Button();
            button.Click += HandleIncomingClick;
        }
    }
}

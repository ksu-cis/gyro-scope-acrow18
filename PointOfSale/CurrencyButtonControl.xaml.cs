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
    /// Interaction logic for CurrencyButtonControl.xaml
    /// </summary>
    public partial class CurrencyButtonControl : UserControl
    {
        public CurrencyButtonControl()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Creates a property for the plus and minus button
        /// </summary>
        public static readonly DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(double), typeof(CurrencyButtonControl), new PropertyMetadata(1.0));

        /// <summary>
        /// The amount each increment or decrement operation should change the value by
        /// </summary>
        public double Step
        {
            get { return (double)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }
    }
}

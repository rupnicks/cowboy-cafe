/* Author: Samantha Rupnick
 * Reference: Zachery Brunner
 * Class: CustomizeCowboyCoffee.xaml.cs
 * Purpose: To hold interaction logic for the customization of the cowboy coffee
 */

using CowboyCafe.Data;
using System;
using System.Windows;
using System.Windows.Controls;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCowboyCoffee.xaml
    /// </summary>
    public partial class CustomizeCowboyCoffee : UserControl
    {
        /// <summary>
        /// The current order of coffee
        /// </summary>
        private Order Order;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="dc"> The data context (cowboy coffee) </param>
        public CustomizeCowboyCoffee(object dc)
        {
            Order = (Order)dc;
            InitializeComponent();
        }

        /// <summary>
        /// What happens when you click the size button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Size size;

            switch (((Button)sender).Name)
            {
                //Size Cases
                case "SmallButton":
                    size = Size.Small;
                    break;
                case "MediumButton":
                    size = Size.Medium;
                    break;
                case "LargeButton":
                    size = Size.Large;
                    break;
                default:
                    throw new NotImplementedException("Unknown Size Button Pressed");
            }
            Order.subtotalHelperFunction((CowboyCoffee)DataContext, size);
            Order.InvokePropertyChanged();
        }
    }
}

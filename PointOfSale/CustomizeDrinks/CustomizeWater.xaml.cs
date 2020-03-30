using System;
/* Author: Samantha Rupnick
 * Reference: Zachery Brunner
 * Class: CustomizeWater.xaml.cs
 * Purpose: To hold interaction logic for the customization of the water
 */

using CowboyCafe.Data;
using System.Windows;
using System.Windows.Controls;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeWater.xaml
    /// </summary>
    public partial class CustomizeWater : UserControl
    {
        /// <summary>
        /// The current order of water
        /// </summary>
        private Order Order;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="dc"> The data context (water) </param>
        public CustomizeWater(object dc)
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
            Order.subtotalHelperFunction((Water)DataContext, size);
            Order.InvokePropertyChanged();
        }
    }
}

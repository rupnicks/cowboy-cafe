/* Author: Samantha Rupnick
 * Reference: Zachery Brunner
 * Class: CustomizeJerkedSoda.xaml.cs
 * Purpose: To hold interaction logic for the customization of the jerked soda
 */

using CowboyCafe.Data;
using System;
using System.Windows;
using System.Windows.Controls;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        /// <summary>
        /// The current order of soda
        /// </summary>
        private Order Order;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="dc"> The data context (jerked soda) </param>
        public CustomizeJerkedSoda(object dc)
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
            Order.subtotalHelperFunction((JerkedSoda)DataContext, size);
            Order.InvokePropertyChanged();
        }

        /// <summary>
        /// What happens when you click the flavor button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flavor_Button_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda soda = (JerkedSoda)DataContext;
            SodaFlavor flavor;

            switch (((Button)sender).Name)
            {
                case "RootBeerButton":
                    flavor = SodaFlavor.RootBeer;
                    break;
                case "OrangeSodaButton":
                    flavor = SodaFlavor.OrangeSoda;
                    break;
                case "CreamSodaButton":
                    flavor = SodaFlavor.CreamSoda;
                    break;
                case "SarsparillaButton":
                    flavor = SodaFlavor.Sarsparilla;
                    break;
                case "BirchBeerButton":
                    flavor = SodaFlavor.BirchBeer;
                    break;
                default:
                    throw new NotImplementedException("Unknown Flavor Button Pressed");
            }
            soda.Flavor = flavor;
            Order.InvokePropertyChanged();
        }
    }
}
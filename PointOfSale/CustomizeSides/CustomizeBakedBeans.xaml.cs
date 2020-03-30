/* Author: Samantha Rupnick
 * Reference: Zachery Brunner
 * Class: CustomizeBakedBeans.xaml.cs
 * Purpose: To handle the customization of the baked beans
 */

using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBakedBeans.xaml
    /// </summary>
    public partial class CustomizeBakedBeans : UserControl
    {
        /// <summary>
        /// The current order of fries
        /// </summary>
        private Order Order;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="dc"> The data context (chili cheese fries) </param>
        public CustomizeBakedBeans(object dc)
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
            Order.subtotalHelperFunction((BakedBeans)DataContext, size);
            Order.InvokePropertyChanged();
        }
    }
}
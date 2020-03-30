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
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    /// 
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        void ItemSelected(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            FrameworkElement screen = null;

            switch (lbi.Content.ToString())
            {
                case "CowboyCoffee":
                    screen = new CustomizeCowboyCoffee(this.DataContext);
                    break;
                case "JerkedSoda":
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    break;
                case "TexasTea":
                    screen = new CustomizeTexasTea(this.DataContext);
                    break;
                case "Water":
                    screen = new CustomizeWater(this.DataContext);
                    break;
                case "AngryChicken":
                    screen = new CustomizeAngryChicken();
                    break;
                case "CowpokeChili":
                    screen = new CustomizeCowpokeChili();
                    break;
                case "DakotaDoubleBurger":
                    screen = new CustomizeDakotaDoubleBurger();
                    break;
                case "PecosPulledPork":
                    screen = new CustomizePecosPulledPork();
                    break;
                case "TexasTripleBurger":
                    screen = new CustomizeTexasTripleBurger();
                    break;
                case "Trailburger":
                    screen = new CustomizeTrailBurger(this.DataContext);
                    break;
                case "BakedBeans":
                    screen = new CustomizeBakedBeans(this.DataContext);
                    break;
                case "ChiliCheeseFries":
                    screen = new CustomizeChiliCheeseFries(this.DataContext);
                    break;
                case "CornDodgers":
                    screen = new CustomizeCornDodgers(this.DataContext);
                    break;
                case "PanDeCampo":
                    screen = new CustomizePanDeCampo(this.DataContext);
                    break;
                default:
                    throw new NotImplementedException("Unknown Item Selected");
            }
            OpenCustomizationMenu(screen);
        }

        /// <summary>
        /// A helper method that changes the screen and adds the item to order
        /// </summary>
        /// <param name="item"> The IOrder item added (entree, side, drink) </param>
        /// <param name="screen"> The customization screen to be switched to </param>
        void OpenCustomizationMenu(FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be an Order instance");

            if (screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Removes the item when the X button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order Order)
            {
                if (sender is Button button)
                {
                    IOrderItem item = button.DataContext as IOrderItem;
                    Order.Remove(item);
                }
            }
        }
    }
}

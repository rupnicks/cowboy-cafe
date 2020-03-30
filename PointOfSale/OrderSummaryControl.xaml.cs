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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private 
            void ItemSelected(object sender, SelectionChangedEventArgs e)
        {
            IOrderItem item = ItemsList.SelectedItem as IOrderItem;
            FrameworkElement screen = null;

            switch (item.ToString())
            {
                case "Small Cowboy Coffee":
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCowboyCoffee(this.DataContext);
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                    break;
                case "Medium Cowboy Coffee":
                    var orderControl2 = this.FindAncestor<OrderControl>();
                    if (orderControl2 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCowboyCoffee(this.DataContext);
                    screen.DataContext = item;
                    orderControl2.SwapScreen(screen);
                    break;
                case "Large Cowboy Coffee":
                    var orderControl3 = this.FindAncestor<OrderControl>();
                    if (orderControl3 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCowboyCoffee(this.DataContext);
                    screen.DataContext = item;
                    orderControl3.SwapScreen(screen);
                    break;
                case "Small Decaf Cowboy Coffee":
                    var orderControl4 = this.FindAncestor<OrderControl>();
                    if (orderControl4 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCowboyCoffee(this.DataContext);
                    screen.DataContext = item;
                    orderControl4.SwapScreen(screen);
                    break;
                case "Medium Decaf Cowboy Coffee":
                    var orderControl5 = this.FindAncestor<OrderControl>();
                    if (orderControl5 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCowboyCoffee(this.DataContext);
                    screen.DataContext = item;
                    orderControl5.SwapScreen(screen);
                    break;
                case "Large Decaf Cowboy Coffee":
                    var orderControl6 = this.FindAncestor<OrderControl>();
                    if (orderControl6 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCowboyCoffee(this.DataContext);
                    screen.DataContext = item;
                    orderControl6.SwapScreen(screen);
                    break;
                case "Small Cream Soda Jerked Soda":
                    var orderControl7 = this.FindAncestor<OrderControl>();
                    if (orderControl7 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl7.SwapScreen(screen);
                    break;
                case "Medium Cream Soda Jerked Soda":
                    var orderControl8 = this.FindAncestor<OrderControl>();
                    if (orderControl8 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl8.SwapScreen(screen);
                    break;
                case "Large Cream Soda Jerked Soda":
                    var orderControl9 = this.FindAncestor<OrderControl>();
                    if (orderControl9 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl9.SwapScreen(screen);
                    break;
                case "Small Orange Soda Jerked Soda":
                    var orderControl10 = this.FindAncestor<OrderControl>();
                    if (orderControl10 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl10.SwapScreen(screen);
                    break;
                case "Medium Orange Soda Jerked Soda":
                    var orderControl11 = this.FindAncestor<OrderControl>();
                    if (orderControl11 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl11.SwapScreen(screen);
                    break;
                case "Large Orange Soda Jerked Soda":
                    var orderControl12 = this.FindAncestor<OrderControl>();
                    if (orderControl12 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl12.SwapScreen(screen);
                    break;
                case "Small Sarsparilla Jerked Soda":
                    var orderControl13 = this.FindAncestor<OrderControl>();
                    if (orderControl13 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl13.SwapScreen(screen);
                    break;
                case "Medium Sarsparilla Jerked Soda":
                    var orderControl14 = this.FindAncestor<OrderControl>();
                    if (orderControl14 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl14.SwapScreen(screen);
                    break;
                case "Large Sarsparilla Jerked Soda":
                    var orderControl15 = this.FindAncestor<OrderControl>();
                    if (orderControl15 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl15.SwapScreen(screen);
                    break;
                case "Small Root Beer Jerked Soda":
                    var orderControl16 = this.FindAncestor<OrderControl>();
                    if (orderControl16 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl16.SwapScreen(screen);
                    break;
                case "Medium Root Beer Jerked Soda":
                    var orderControl17 = this.FindAncestor<OrderControl>();
                    if (orderControl17 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl17.SwapScreen(screen);
                    break;
                case "Large Root Beer Jerked Soda":
                    var orderControl18 = this.FindAncestor<OrderControl>();
                    if (orderControl18 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl18.SwapScreen(screen);
                    break;
                case "Small Birch Beer Jerked Soda":
                    var orderControl19 = this.FindAncestor<OrderControl>();
                    if (orderControl19 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl19.SwapScreen(screen);
                    break;
                case "Medium Birch Beer Jerked Soda":
                    var orderControl20 = this.FindAncestor<OrderControl>();
                    if (orderControl20 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl20.SwapScreen(screen);
                    break;
                case "Large Birch Beer Jerked Soda":
                    var orderControl21 = this.FindAncestor<OrderControl>();
                    if (orderControl21 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeJerkedSoda(this.DataContext);
                    screen.DataContext = item;
                    orderControl21.SwapScreen(screen);
                    break;
                case "Small Texas Tea":
                    var orderControl22 = this.FindAncestor<OrderControl>();
                    if (orderControl22 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeTexasTea(this.DataContext);
                    screen.DataContext = item;
                    orderControl22.SwapScreen(screen);
                    break;
                case "Medium Texas Tea":
                    var orderControl23 = this.FindAncestor<OrderControl>();
                    if (orderControl23 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeTexasTea(this.DataContext);
                    screen.DataContext = item;
                    orderControl23.SwapScreen(screen);
                    break;
                case "Large Texas Tea":
                    var orderControl24 = this.FindAncestor<OrderControl>();
                    if (orderControl24 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeTexasTea(this.DataContext);
                    screen.DataContext = item;
                    orderControl24.SwapScreen(screen);
                    break;
                case "Small Water":
                    var orderControl25 = this.FindAncestor<OrderControl>();
                    if (orderControl25 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeWater(this.DataContext);
                    screen.DataContext = item;
                    orderControl25.SwapScreen(screen);
                    break;
                case "Medium Water":
                    var orderControl26 = this.FindAncestor<OrderControl>();
                    if (orderControl26 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeWater(this.DataContext);
                    screen.DataContext = item;
                    orderControl26.SwapScreen(screen);
                    break;
                case "Large Water":
                    var orderControl27 = this.FindAncestor<OrderControl>();
                    if (orderControl27 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeWater(this.DataContext);
                    screen.DataContext = item;
                    orderControl27.SwapScreen(screen);
                    break;
                case "Angry Chicken":
                    var orderControl28 = this.FindAncestor<OrderControl>();
                    if (orderControl28 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeAngryChicken(this.DataContext);
                    screen.DataContext = item;
                    orderControl28.SwapScreen(screen);
                    break;
                case "Cowpoke Chili":
                    var orderControl29 = this.FindAncestor<OrderControl>();
                    if (orderControl29 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCowpokeChili(this.DataContext);
                    screen.DataContext = item;
                    orderControl29.SwapScreen(screen);
                    break;
                case "Dakota Double Burger":
                    var orderControl30 = this.FindAncestor<OrderControl>();
                    if (orderControl30 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeDakotaDoubleBurger(this.DataContext);
                    screen.DataContext = item;
                    orderControl30.SwapScreen(screen);
                    break;
                case "Peco's Pulled Pork":
                    var orderControl31 = this.FindAncestor<OrderControl>();
                    if (orderControl31 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizePecosPulledPork(this.DataContext);
                    screen.DataContext = item;
                    orderControl31.SwapScreen(screen);
                    break;
                case "Texas Triple Burger":
                    var orderControl32 = this.FindAncestor<OrderControl>();
                    if (orderControl32 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeTexasTripleBurger(this.DataContext);
                    screen.DataContext = item;
                    orderControl32.SwapScreen(screen); break;
                case "Trailburger":
                    var orderControl33 = this.FindAncestor<OrderControl>();
                    if (orderControl33 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeTrailBurger(this.DataContext);
                    screen.DataContext = item;
                    orderControl33.SwapScreen(screen); break;
                case "Small Baked Beans":
                    var orderControl34 = this.FindAncestor<OrderControl>();
                    if (orderControl34 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeBakedBeans(this.DataContext);
                    screen.DataContext = item;
                    orderControl34.SwapScreen(screen);
                    break;
                case "Medium Baked Beans":
                    var orderControl35 = this.FindAncestor<OrderControl>();
                    if (orderControl35 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeBakedBeans(this.DataContext);
                    screen.DataContext = item;
                    orderControl35.SwapScreen(screen);
                    break;
                case "Large Baked Beans":
                    var orderControl36 = this.FindAncestor<OrderControl>();
                    if (orderControl36 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeBakedBeans(this.DataContext);
                    screen.DataContext = item;
                    orderControl36.SwapScreen(screen);
                    break;
                case "Small Chili Cheese Fries":
                    var orderControl37 = this.FindAncestor<OrderControl>();
                    if (orderControl37 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeChiliCheeseFries(this.DataContext);
                    screen.DataContext = item;
                    orderControl37.SwapScreen(screen);
                    break;
                case "Medium Chili Cheese Fries":
                    var orderControl38 = this.FindAncestor<OrderControl>();
                    if (orderControl38 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeChiliCheeseFries(this.DataContext);
                    screen.DataContext = item;
                    orderControl38.SwapScreen(screen);
                    break;
                case "Large Chili Cheese Fries":
                    var orderControl39 = this.FindAncestor<OrderControl>();
                    if (orderControl39 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeChiliCheeseFries(this.DataContext);
                    screen.DataContext = item;
                    orderControl39.SwapScreen(screen);
                    break;
                case "Small Corn Dodgers":
                    var orderControl40 = this.FindAncestor<OrderControl>();
                    if (orderControl40 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCornDodgers(this.DataContext);
                    screen.DataContext = item;
                    orderControl40.SwapScreen(screen);
                    break;
                case "Medium Corn Dodgers":
                    var orderControl41 = this.FindAncestor<OrderControl>();
                    if (orderControl41 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCornDodgers(this.DataContext);
                    screen.DataContext = item;
                    orderControl41.SwapScreen(screen);
                    break;
                case "Large Corn Dodgers":
                    var orderControl42 = this.FindAncestor<OrderControl>();
                    if (orderControl42 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizeCornDodgers(this.DataContext);
                    screen.DataContext = item;
                    orderControl42.SwapScreen(screen);
                    break;
                case "Small Pan De Campo":
                    var orderControl43 = this.FindAncestor<OrderControl>();
                    if (orderControl43 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizePanDeCampo(this.DataContext);
                    screen.DataContext = item;
                    orderControl43.SwapScreen(screen);
                    break;
                case "Medium Pan De Campo":
                    var orderControl44 = this.FindAncestor<OrderControl>();
                    if (orderControl44 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizePanDeCampo(this.DataContext);
                    screen.DataContext = item;
                    orderControl44.SwapScreen(screen);
                    break;
                case "Large Pan De Campo":
                    var orderControl45 = this.FindAncestor<OrderControl>();
                    if (orderControl45 == null) throw new Exception("An ancestor of OrderControl expected");
                    screen = new CustomizePanDeCampo(this.DataContext);
                    screen.DataContext = item;
                    orderControl45.SwapScreen(screen);
                    break;
                default:
                    throw new NotImplementedException("Unknown Item Selected");
            }
            //OpenCustomizationMenu(item, screen);
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

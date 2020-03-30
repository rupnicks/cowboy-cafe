/* Author: Samantha Rupnick
 * Class: MenuItemSelectionControl.cs
 * Purpose: Handles the changing of screens and adding of items
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when an add button is clicked
        /// </summary>
        /// <param name="sender"> The button that was clicked </param>
        /// <param name="e"> The event arguments </param>
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            IOrderItem item;
            FrameworkElement screen = null;
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch(button.Tag)
                    {                        
                        case "CowpokeChili":
                            var chili = new CowpokeChili();
                            var chiliScreen = new CustomizeCowpokeChili(DataContext);
                            AddItemAndOpenCustomizationMenu(chili, chiliScreen);
                            break;
                        case "TrailBurger":
                            var burger = new TrailBurger();
                            var burgerScreen = new CustomizeTrailBurger(DataContext);
                            AddItemAndOpenCustomizationMenu(burger, burgerScreen);
                            break;
                        case "DakotaDouble":
                            var doubleBurger = new DakotaDoubleBurger();
                            var doubleScreen = new CustomizeDakotaDoubleBurger(DataContext);
                            AddItemAndOpenCustomizationMenu(doubleBurger, doubleScreen);
                            break;
                        case "TexasTriple":
                            var triple = new TexasTripleBurger();
                            var tripleScreen = new CustomizeTexasTripleBurger(DataContext);
                            AddItemAndOpenCustomizationMenu(triple, tripleScreen);
                            break;
                        case "AngryChicken":
                            var chicken = new AngryChicken();
                            var chickenScreen = new CustomizeAngryChicken(DataContext);
                            AddItemAndOpenCustomizationMenu(chicken, chickenScreen);
                            break;
                        case "PecosPulledPork":
                            var pulled = new PecosPulledPork();
                            var pulledScreen = new CustomizePecosPulledPork(DataContext);
                            AddItemAndOpenCustomizationMenu(pulled, pulledScreen);
                            break;
                        case "RustlersRibs":
                            var ribs = new RustlersRibs();
                            order.Add(ribs);
                            break;
                        case "BakedBeans":
                            item = new BakedBeans();
                            screen = new CustomizeBakedBeans(DataContext);
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                        case "ChiliCheeseFries":
                            item = new ChiliCheeseFries();
                            screen = new CustomizeChiliCheeseFries(DataContext);
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                        case "CornDodgers":
                            item = new CornDodgers();
                            screen = new CustomizeCornDodgers(DataContext);
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                        case "PanDeCampo":
                            item = new PanDeCampo();
                            screen = new CustomizePanDeCampo(DataContext);
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                        case "CowboyCoffee":
                            item = new CowboyCoffee();
                            screen = new CustomizeCowboyCoffee(DataContext);
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                        case "JerkedSoda":
                            item = new JerkedSoda();
                            screen = new CustomizeJerkedSoda(DataContext);
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                        case "TexasTea":
                            item = new TexasTea();
                            screen = new CustomizeTexasTea(DataContext);
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                        case "Water":
                            item = new Water();
                            screen = new CustomizeWater(DataContext);
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// A helper method that changes the screen and adds the item to order
        /// </summary>
        /// <param name="item"> The IOrder item added (entree, side, drink) </param>
        /// <param name="screen"> The customization screen to be switched to </param>
        void AddItemAndOpenCustomizationMenu(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be an Order instance");

            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            order.Add(item);
        }
    }
}
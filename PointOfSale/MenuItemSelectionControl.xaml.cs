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
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch(button.Tag)
                    {                        
                        case "CowpokeChili":
                            var chili = new CowpokeChili();
                            var chiliScreen = new CustomizeCowpokeChili();
                            AddItemAndOpenCustomizationMenu(chili, chiliScreen);
                            break;
                        case "TrailBurger":
                            var burger = new TrailBurger();
                            var burgerScreen = new CustomizeTrailBurger();
                            AddItemAndOpenCustomizationMenu(burger, burgerScreen);
                            break;
                        case "DakotaDouble":
                            var doubleBurger = new DakotaDoubleBurger();
                            var doubleScreen = new CustomizeDakotaDoubleBurger();
                            AddItemAndOpenCustomizationMenu(doubleBurger, doubleScreen);
                            break;
                        case "TexasTriple":
                            var triple = new TexasTripleBurger();
                            var tripleScreen = new CustomizeTexasTripleBurger();
                            AddItemAndOpenCustomizationMenu(triple, tripleScreen);
                            break;
                        case "AngryChicken":
                            var chicken = new AngryChicken();
                            var chickenScreen = new CustomizeAngryChicken();
                            AddItemAndOpenCustomizationMenu(chicken, chickenScreen);
                            break;
                        case "PecosPulledPork":
                            var pulled = new PecosPulledPork();
                            var pulledScreen = new CustomizePecosPulledPork();
                            AddItemAndOpenCustomizationMenu(pulled, pulledScreen);
                            break;
                        case "RustlersRibs":
                            var ribs = new RustlersRibs();
                            order.Add(ribs);
                            break;
                        case "BakedBeans":
                            order.Add(new BakedBeans());
                            break;
                        case "ChiliCheeseFries":
                            order.Add(new ChiliCheeseFries());
                            break;
                        case "CornDodgers":
                            order.Add(new CornDodgers());
                            break;
                        case "PanDeCampo":
                            order.Add(new PanDeCampo());
                            break;
                        case "CowboyCoffee":
                            order.Add(new CowboyCoffee());
                            break;
                        case "JerkedSoda":
                            order.Add(new JerkedSoda());
                            break;
                        case "TexasTea":
                            order.Add(new TexasTea());
                            break;
                        case "Water":
                            var water = new Water();
                            var waterScreen = new CustomizeWater();
                            AddItemAndOpenCustomizationMenu(water, waterScreen);
                            break;
                    }
                }
            }
        }

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
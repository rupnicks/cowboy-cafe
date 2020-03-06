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
                            var item = new CowpokeChili();
                            var screen = new CustomizeCowpokeChili();
                            AddItemAndOpenCustomizationMenu(item, screen);
                            break;
                        case "TrailBurger":
                            order.Add(new TrailBurger());
                            break;
                        case "DakotaDouble":
                            order.Add(new DakotaDoubleBurger());
                            break;
                        case "TexasTriple":
                            order.Add(new TexasTripleBurger());
                            break;
                        case "AngryChicken":
                            order.Add(new AngryChicken());
                            break;
                        case "PecosPulledPork":
                            order.Add(new PecosPulledPork());
                            break;
                        case "RustlersRibs":
                            order.Add(new RustlersRibs());
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
                            order.Add(new Water());
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
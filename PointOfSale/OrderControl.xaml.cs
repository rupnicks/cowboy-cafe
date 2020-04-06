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
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            Order order = new Order(1);
            this.DataContext = order;
            InitializeComponent();
        }

        public void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {
            Order order = (Order)this.DataContext;
            this.DataContext = new Order(order.OrderNumber + 1);
            Container.Child = new MenuItemSelectionControl();
        }

        public void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new TransactionControl();
        }

        public void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

    }
}

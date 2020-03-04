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
            InitializeComponent();
            DataContext = new Order();

            //CancelOrder.Click += OnCancelButtonClicked();
            //CompleteOrder.Click += OnCompleteOrderButtonClicked();
        }

        public void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

    }
}

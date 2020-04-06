/* Author: Samantha Rupnick
 * Class: TransactionControl.xaml.cs
 * Purpose: Handles how payments are processed
 */

using CashRegister;
using CowboyCafe.Data;
using CowboyCafe.Extensions;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        static CashDrawer drawer = new CashDrawer();

        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the transaction for a credit card purchase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Credit_Button_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)this.DataContext;
            CardTerminal credit = new CardTerminal();
            ResultCode result = credit.ProcessTransaction(order.Total);
            string Error = "";
            switch(result.ToString())
            {
                case "Success":
                    PrintReceipt();
                    break;
                case "InsufficientFunds":
                    Error = "Insufficient Funds";
                    break;
                case "CancelledCard":
                    Error = "Cancelled Card";
                    break;
                case "ReadError":
                    Error = "Read Error";
                    break;
                default:
                    Error = "Unknown Error";
                    break;
            }
        }

        /// <summary>
        /// Handles the transaction for a cash purchase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Cash_Button_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)this.DataContext;
            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");
            orderControl.SwapScreen(new CashPaymentScreen(drawer, order));
            PrintReceipt();
        }

        /// <summary>
        /// Handles the interaction for cancelling a purchase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");
            Order order = (Order)this.DataContext;
            this.DataContext = new Order(order.OrderNumber + 1);
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Prints the receipt for the transaction
        /// </summary>
        private void PrintReceipt()
        {
            ReceiptPrinter receipt = new ReceiptPrinter();
            receipt.Print("test");

            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");
            Order order = (Order)this.DataContext;
            this.DataContext = new Order(order.OrderNumber + 1);
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }
    }
}

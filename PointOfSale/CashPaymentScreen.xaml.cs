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
using CashRegister;
using CowboyCafe.Data;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentScreen.xaml
    /// </summary>
    public partial class CashPaymentScreen : UserControl
    {
        public CashDrawer Drawer;
        public Order Order;
        public CashPaymentScreen(CashDrawer drawer, Order order)
        {
            Drawer = drawer;
            Order = order;
            InitializeComponent();
        }

        public void Payment(double t, double p)
        {
            t -= p;
        }

        public void Change(CashDrawer d, double change)
        {
            int penniesCount = 0;
            int nickelsCount = 0;
            int dimesCount = 0;
            int quartersCount = 0;
            int halfDollarsCount = 0;
            int dollarsCount = 0;
            int onesCount = 0;
            int twosCount = 0;
            int fivesCount = 0;
            int tensCount = 0;
            int twentiesCount = 0;
            int fiftiesCount = 0;
            int hundredsCount = 0;

            while (change != 0)
            {
                //find highest denomination
                //change -= (denomination);
                //switch denomination needed, cases increment related count
            }
            //check if drawer has the change
            //display change needed
        }
    }
}

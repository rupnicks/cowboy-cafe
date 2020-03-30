/*
 * Author: Samantha Rupnick
 * Class: CustomizeCowpokeChili.xaml.cs
 * Purpose: Holds interaction logic for the xaml class
 */

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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCowpokeChili.xaml
    /// </summary>
    public partial class CustomizeCowpokeChili : UserControl
    {
        public Order Order;
        public CustomizeCowpokeChili(object dc)
        {
            Order = (Order)dc;
            InitializeComponent();
        }
    }
}

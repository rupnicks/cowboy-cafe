﻿/*
 * Author: Samantha Rupnick
 * Class: CustomizeTrailBurger.xaml.cs
 * Purpose: Holds interaction logic for the xaml class
 */

using CowboyCafe.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTrailBurger.xaml
    /// </summary>
    public partial class CustomizeTrailBurger : UserControl
    {
        public Order Order;
        public CustomizeTrailBurger(object dc)
        {
            Order = (Order)dc;
            InitializeComponent();
        }
    }
}

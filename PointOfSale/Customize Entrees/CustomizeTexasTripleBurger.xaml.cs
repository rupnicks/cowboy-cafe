﻿/*
 * Author: Samantha Rupnick
 * Class: CustomizeTexasTripleBurger.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTexasTripleBurger.xaml
    /// </summary>
    public partial class CustomizeTexasTripleBurger : UserControl
    {
        public Object Object;
        public CustomizeTexasTripleBurger(object dc)
        {
            Object = (Object)dc;
            InitializeComponent();
        }
    }
}

﻿/*
 * Author: Samantha Rupnick
 * Class: CustomizePecosPulledPork.xaml.cs
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
    /// Interaction logic for CustomizePecosPulledPork.xaml
    /// </summary>
    public partial class CustomizePecosPulledPork : UserControl
    {
        public Object Object;
        public CustomizePecosPulledPork(object dc)
        {
            Object = (Object)dc;
            InitializeComponent();
        }
    }
}

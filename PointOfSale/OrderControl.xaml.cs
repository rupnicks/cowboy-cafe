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
    public partial class OrderControl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public OrderControl()
        {
            InitializeComponent();
            var data = new Order();
            DataContext = data;

            CancelOrder.Click += OnCancelButtonClicked();
            CompleteOrder.Click += OnCompleteOrderButtonClicked();
            ItemSelection.Click += OnItemSelectionButtonClicked();
        }

        void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

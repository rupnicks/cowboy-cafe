/* Author: Samantha Rupnick
 * Class: Order.cs
 * Purpose: To hold data for an order
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {
        static uint lastOrderNumber = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

        public double Subtotal { get; set; }

        public uint OrderNumber { get { return lastOrderNumber; } }

        public event PropertyChangedEventHandler PropertyChanged;

        public Order(uint orderNumber)
        {
            lastOrderNumber += 1;
        }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            Subtotal += item.Price;
            if (item is INotifyPropertyChanged notifier) { notifier.PropertyChanged += OnItemPropertyChanged; }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            Subtotal -= item.Price;
            if (item is INotifyPropertyChanged notifier) { notifier.PropertyChanged -= OnItemPropertyChanged; }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if(e.PropertyName == "Price") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal")); }
        }
    }
}

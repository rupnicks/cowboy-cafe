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
    public class Order
    {
        static uint lastOrderNumber = 0;

        public IEnumerable<IOrderItem> Items => items;

        private List<IOrderItem> items = new List<IOrderItem>(); 

        public double Subtotal { get; set; }

        public uint OrderNumber { get { return lastOrderNumber + 1; } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {
            items.Add(item);
            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            Subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}

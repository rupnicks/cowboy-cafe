/* Author: Samantha Rupnick
 * Reference: Zachery Brunner
 * Class: Order.cs
 * Purpose: To hold data for an order
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Holds data for an order
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Remembers the order number of the last order to generate a new one when a new order is created
        /// </summary>
        static uint lastOrderNumber = 0;

        /// <summary>
        /// Creates a list of order items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// A public list of order items to be displayed
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// The list of the item prices on the current order
        /// </summary>
        private List<string> itemPrices = new List<string>();

        /// <summary>
        /// The subtotal of the order
        /// </summary>
        public double Subtotal { get; private set; }

        /// <summary>
        /// The current order number
        /// </summary>
        public uint OrderNumber { get { return lastOrderNumber; } }

        /// <summary>
        /// Event handler for the class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creates a new order and initializes the last order number
        /// </summary>
        /// <param name="orderNumber"></param>
        public Order(uint orderNumber)
        {
            lastOrderNumber += 1;
        }

        /// <summary>
        /// Adds the selected item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);

            //Puts item in currency format to be added to the item prices list (thanks Zachery)
            string priceOfItemAsCurrency = String.Format("{0:C}", item.Price);
            itemPrices.Add(priceOfItemAsCurrency);

            Subtotal += item.Price;
            if (item is INotifyPropertyChanged notifier) { notifier.PropertyChanged += OnItemPropertyChanged; }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes the selected item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            string priceOfItemAsCurrency = String.Format("{0:C}", item.Price);
            itemPrices.Remove(priceOfItemAsCurrency);
            Subtotal -= item.Price;
            items.Remove(item);
            if (item is INotifyPropertyChanged notifier) { notifier.PropertyChanged -= OnItemPropertyChanged; }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Event handler for when an item property (size, flavor, or customization) is changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if(e.PropertyName == "Price") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal")); }
        }

        /// <summary>
        /// Double checking by invoking all elements to ensure nothing is missed
        /// Thanks Zachery
        /// </summary>
        public void InvokePropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// This method assists in updating the subtotal for changing sizes
        /// </summary>
        /// <param name="i">The item</param>
        /// <param name="new_size">The size the item is suppose to be</param>
        public void subtotalHelperFunction(IOrderItem i, Size new_size)
        {
            Side s;
            Drink d;

            Subtotal -= i.Price;
            if (i is Side)
            {
                s = (Side)i;
                s.Size = new_size;
                Subtotal += s.Price;
            }
            else
            {
                d = (Drink)i;
                d.Size = new_size;
                Subtotal += d.Price;
            }
            itemPrices.RemoveAt(itemPrices.Count - 1);

            string priceOfItemAsCurrency = String.Format("{0:C}", i.Price);
            itemPrices.Add(priceOfItemAsCurrency);
        }
    }
}

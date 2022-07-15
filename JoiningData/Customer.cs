using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningData
{
    internal class Customer
    {
        //properties
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        //constrcutor
        public Customer(string _customerName, string _item, decimal _price, int _quantity)
        {
            CustomerName = _customerName;
            Item = _item;
            Price = _price;
            Quantity = _quantity;
        }
    }
}

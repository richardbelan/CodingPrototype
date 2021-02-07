using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.OrderItems
{
    public class Book : OrderItem
    {
        public Book(string name) { _name = name; }
        public static OrderItem GetOrderItem(string name)
        {
            return new Book(name);
        }
        //             throw new NotImplementedException();

    }
}

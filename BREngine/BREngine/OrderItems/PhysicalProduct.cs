using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.OrderItems
{
    public class PhysicalProduct : OrderItem
    {
        public PhysicalProduct(string name) { _name = name; }
        public static OrderItem GetOrderItem(string name)
        {
            throw new NotImplementedException();
            return new PhysicalProduct(name);
        }
    }
}

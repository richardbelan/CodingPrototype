using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.OrderItems
{
    public class Book : PhysicalProduct
    {
        public Book(string name) : base(name) { }
        public new static OrderItem GetOrderItem(string name)
        {
            return new Book(name);
        }
        public override void Process()
        {
            base.Process();
            BREngine.Proxy.RoyaltyDeptProxyFacade.Instance.GeneratePackingSlip(_name);
        }
    }
}

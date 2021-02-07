using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.OrderItems
{
    public class Video : PhysicalProduct
    {
        public Video(string name) : base(name) { }
        public new static OrderItem GetOrderItem(string name)
        {
            return new Video(name);
        }
        public override void Process()
        {
            base.Process();

            // the inventory wouldn't be happy for just adding new slip
            if (_name == "Learning To Ski")
                BREngine.Proxy.ShippingDeptProxyFacade.Instance.GeneratePackingSlip("First Aid");
        }
    }
}

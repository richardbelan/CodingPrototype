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
            return new PhysicalProduct(name);
        }
        public override void Process()
        {
            BREngine.Proxy.ShippingDeptProxyFacade.Instance.GeneratePackingSlip(_name);
            BREngine.Proxy.AgentCommissionProxyFacade.Instance.GenerateCommission(_name);
        }

    }
}

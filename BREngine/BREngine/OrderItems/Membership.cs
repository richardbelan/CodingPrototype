using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.OrderItems
{
    public class Membership : OrderItem
    {
        public Membership(string name) { _name = name; }
        public static OrderItem GetOrderItem(string name)
        {
            return new Membership(name);
        }
        public override void Process()
        {
            // Time limitation prevents more proper handling of membership
            if(_name == "NEW")
                BREngine.Proxy.MemberShipProxyFacade.Instance.Activate();
            else BREngine.Proxy.MemberShipProxyFacade.Instance.Upgrade();
            BREngine.Proxy.MemberShipProxyFacade.Instance.EmailOwner(_name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.Proxy
{
    // This class is singleton as it represents an proxy to an external system.
    public class OrdersProxyFacade : ProxyFacade
    {
        private static OrdersProxyFacade instance = null;
        public static OrdersProxyFacade Instance
        {
            get
            {
                // no need to lock, this is an single threaded library
                if (instance == null)
                    instance = new OrdersProxyFacade();
                return instance;
            }
        }

        public OrdersProxyFacade() { }
        public void GeneratePackingSlip(string name)
        {
            this.GenerateTransaction();
            Console.WriteLine("OrdersProxyFacade.GeneratePackingSlip:" + name);
        }
    }
}

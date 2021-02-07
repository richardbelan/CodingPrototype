using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.Proxy
{
    // This class is singleton as it represents an proxy to an external system.
    public class ShippingDeptProxyFacade : ProxyFacade
    {
        private static ShippingDeptProxyFacade instance = null;
        public static ShippingDeptProxyFacade Instance
        {
            get
            {
                throw new NotImplementedException();

                // no need to lock, this is an single threaded library
                if (instance == null)
                    instance = new ShippingDeptProxyFacade();
                return instance;
            }
        }

        public ShippingDeptProxyFacade() {}
        public void GeneratePackingSlip()
        {
            throw new NotImplementedException();
        }
    }
}

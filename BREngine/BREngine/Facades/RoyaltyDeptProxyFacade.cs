using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.Proxy
{
    // This class is singleton as it represents an proxy to an external system.
    public class RoyaltyDeptProxyFacade : ProxyFacade
    {
        private static RoyaltyDeptProxyFacade instance = null;
        public static RoyaltyDeptProxyFacade Instance
        {
            get
            {
                // no need to lock, this is an single threaded library
                if (instance == null)
                    instance = new RoyaltyDeptProxyFacade();
                return instance;
            }
        }

        public RoyaltyDeptProxyFacade() { }
        public void GeneratePackingSlip()
        {
            throw new NotImplementedException();
        }
    }
}

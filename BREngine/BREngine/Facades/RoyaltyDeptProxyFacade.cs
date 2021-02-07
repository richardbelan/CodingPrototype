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

                System.Diagnostics.Debug.WriteLine("RoyaltyDeptProxyFacade.GeneratePackingSlip");
                return instance;
            }
        }

        public RoyaltyDeptProxyFacade() { }
        public void GeneratePackingSlip(string name)
        {
            this.GenerateTransaction();
            Console.WriteLine("RoyaltyDeptProxyFacade.GeneratePackingSlip: " + name);
        }
    }
}

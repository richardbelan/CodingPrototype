using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.Proxy
{
    // This class is singleton as it represents an proxy to an external system.
    public class MemberShipProxyFacade : ProxyFacade
    {
        private static MemberShipProxyFacade instance = null;
        public static MemberShipProxyFacade Instance
        {
            get
            {
                // no need to lock, this is an single threaded library
                if (instance == null)
                    instance = new MemberShipProxyFacade();
                return instance;
            }
        }

        public MemberShipProxyFacade() { }
        public void Activate()
        {
            this.GenerateTransaction();
        }
        public void Upgrade()
        {
            this.GenerateTransaction();
        }
        public void EmailOwner()
        {
            this.GenerateTransaction();
        }
    }
}

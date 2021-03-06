﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.Proxy
{
    // This class is singleton as it represents an proxy to an external system.
    public class AgentCommissionProxyFacade : ProxyFacade
    {
        private static AgentCommissionProxyFacade instance = null;
        public static AgentCommissionProxyFacade Instance
        {
            get
            {
                // no need to lock, this is an single threaded library
                if (instance == null)
                    instance = new AgentCommissionProxyFacade();
                return instance;
            }
        }

        public AgentCommissionProxyFacade() { }
        public void GenerateCommission(string name)
        {
            this.GenerateTransaction();
            Console.WriteLine("Generating commission for " + name);
        }
    }
}

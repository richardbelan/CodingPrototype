using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine
{
    public class ProxyFacade
    {
        private int noOfTransactions = 0;
        public int NoOfTransactions { get => noOfTransactions; }

        public ProxyFacade() {}
        public void GenerateTransaction()
        {
            noOfTransactions++;
        }
    }
}

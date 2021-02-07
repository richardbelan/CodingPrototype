using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine
{
    public class ProxyFacade
    {
        public int NoOfTransactions { get; } = 0;

        public ProxyFacade() {}
        public void GenerateTransaction()
        {
            throw new NotImplementedException();
        }
    }
}

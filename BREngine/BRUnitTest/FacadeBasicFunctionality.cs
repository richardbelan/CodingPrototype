using Microsoft.VisualStudio.TestTools.UnitTesting;

using BREngine.Proxy;

namespace BRUnitTest
{
    // I cannot generate all test for all function within the time frame given for this project
    [TestClass]
    public class FacadeBasicFunctionality
    {
        [TestMethod]
        public void TestAgentCommissionProxyFacade()
        {
            try
            {
                AgentCommissionProxyFacade instance = AgentCommissionProxyFacade.Instance;
                int noOfTx = instance.NoOfTransactions;
                instance.GenerateCommission("no name");
                
                Assert.AreEqual(noOfTx+1, instance.NoOfTransactions);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMemberShipProxyFacade()
        {
            try
            {
                MemberShipProxyFacade instance = MemberShipProxyFacade.Instance;
                int noOfTx = instance.NoOfTransactions;
                instance.Activate();

                Assert.AreEqual(noOfTx + 1, instance.NoOfTransactions);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestOrdersProxyFacade()
        {
            try
            {
                OrdersProxyFacade instance = OrdersProxyFacade.Instance;
                int noOfTx = instance.NoOfTransactions;
                instance.GeneratePackingSlip("No name");

                Assert.AreEqual(noOfTx + 1, instance.NoOfTransactions);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestRoyaltyDeptProxyFacade()
        {
            try
            {
                RoyaltyDeptProxyFacade instance = RoyaltyDeptProxyFacade.Instance;
                int noOfTx = instance.NoOfTransactions;
                instance.GeneratePackingSlip("no name");

                Assert.AreEqual(noOfTx + 1, instance.NoOfTransactions);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestShippingDeptProxyFacade()
        {
            try
            {
                ShippingDeptProxyFacade instance = ShippingDeptProxyFacade.Instance;
                int noOfTx = instance.NoOfTransactions;
                instance.GeneratePackingSlip("no name");

                Assert.AreEqual(noOfTx + 1, instance.NoOfTransactions);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
    }
}

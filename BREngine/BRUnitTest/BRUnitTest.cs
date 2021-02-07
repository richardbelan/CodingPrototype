using Microsoft.VisualStudio.TestTools.UnitTesting;

using BREngine.Proxy;

namespace BRUnitTest
{
    [TestClass]
    public class FacadeUnitTests
    {
        [TestMethod]
        public void TestAgentCommissionProxyFacade()
        {
            try
            {
                AgentCommissionProxyFacade instance = AgentCommissionProxyFacade.Instance;
                Assert.IsNotNull(instance);
            }
            catch(System.Exception)
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
                Assert.IsNotNull(instance);
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
                Assert.IsNotNull(instance);
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
                Assert.IsNotNull(instance);
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
                Assert.IsNotNull(instance);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
    }
}

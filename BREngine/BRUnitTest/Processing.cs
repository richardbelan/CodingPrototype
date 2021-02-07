using Microsoft.VisualStudio.TestTools.UnitTesting;

using BREngine.OrderItems;

namespace BRUnitTest
{
    // I cannot generate all test for all function within the time frame given for this project
    [TestClass]
    public class Processing
    {
        [TestMethod]
        public void TestBookProcessing()
        {
            try
            {
                OrderItem item = Book.GetOrderItem("My book");
                item.Process();

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestPhysicalProductProcessing()
        {
            try
            {
                OrderItem item = PhysicalProduct.GetOrderItem("My product");
                item.Process();

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestVideoProcessing()
        {
            try
            {
                OrderItem item = Video.GetOrderItem("My video");
                item.Process();

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestVideoLearningToSki()
        {
            try
            {
                OrderItem item = Video.GetOrderItem("Learning To Ski");
                item.Process();

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestNEWMembershipProcessing()
        {
            try
            {
                OrderItem item = Membership.GetOrderItem("NEW");
                item.Process();

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestUpgradeMembershipProcessing()
        {
            try
            {
                OrderItem item = Membership.GetOrderItem("Upgrade");
                item.Process();

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
    }
}


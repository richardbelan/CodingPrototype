using Microsoft.VisualStudio.TestTools.UnitTesting;

using BREngine.OrderItems;

namespace BRUnitTest
{
    // I cannot generate all test for all function within the time frame given for this project
    [TestClass]
    public class OrderItemsFactory
    {
        [TestMethod]
        public void TestBookFactory()
        {
            try
            {
                OrderItem item = Book.GetOrderItem("My book");

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestPhysicalProductFactory()
        {
            try
            {
                OrderItem item = PhysicalProduct.GetOrderItem("My product");

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestVideoFactory()
        {
            try
            {
                OrderItem item = Video.GetOrderItem("My video");

                Assert.IsNotNull(item);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
    }
}

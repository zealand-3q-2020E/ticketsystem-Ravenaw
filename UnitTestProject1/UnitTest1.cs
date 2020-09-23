using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double price;
            ClassLibrary.Car car=new Car();

            price = car.Price();

            Assert.AreEqual(price, 240);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string type;
            ClassLibrary.Car car = new Car();

            type = car.VehicleType();

            Assert.AreEqual(type, "Car");
        }

        [TestMethod]
        public void TestMethod3()
        {
            double price;
            ClassLibrary.MC mc = new MC();

            price = mc.Price();

            Assert.AreEqual(price, 125);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string type;
            ClassLibrary.MC mc = new MC();

            type = mc.VehicleType();

            Assert.AreEqual(type, "MC");
        }
    }
}

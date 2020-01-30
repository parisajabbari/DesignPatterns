using Moq;
using NUnit.Framework;
using StrategyMethod;


namespace test
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {

            
            
        }

        [Test]
        public void ReturnNormalPrice_WhenStrategyIsNormal()
        {
            var sut = new NormalPricing();
            var _customer = new Customer(sut);
            var _normalPrice = _customer.GetPrice(10);       
            Assert.AreEqual(_normalPrice, 10.0);          
        }
        
        [Test]
        public void ReturnHappyHourPrice_WhenStrategyIsHappyHour()
        {
            var sut = new HappyHourPricing();
            var _customer = new Customer(sut);
            var _normalPrice = _customer.GetPrice(10);       
            Assert.AreEqual(_normalPrice, 5.0);


        }
    }
}
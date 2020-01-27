using Moq;
using NUnit.Framework;
using Decorator;

namespace Tests
{
    public class Tests
    {
        private Mock<ICoffee> _coffee;
        private Coffee _basicCoffee;
        private WithMilk _withMilk;
        private WithSprinkle _withSprinkle;
        
        [SetUp]
        public void Setup()
        {
            _coffee = new Mock<ICoffee>();
            _basicCoffee = new Coffee();
            _withMilk = new WithMilk(_coffee.Object);
            _withSprinkle = new WithSprinkle(_coffee.Object);

            _coffee.Setup(coffee => coffee.Cost()).Returns(1.0);
        }

        [Test]
        public void BasicCoffeeCostTest()
        {
            Assert.AreEqual(_basicCoffee.Cost(), 1.0);
        }

        [Test]
        public void WithMilkCoffeeTest()
        {
            Assert.AreEqual(_withMilk.Cost(), 1.5);
        }

        [Test]
        public void WithSprinkleTest()
        {
            Assert.AreEqual(_withSprinkle.Cost(), 1.2);
        }

        [Test]
        public void CoffeeWithMilkAndSprinkle()
        {
            var CoffeeWithMilkAndSprinkle = new WithSprinkle(_withMilk);
            Assert.AreEqual(CoffeeWithMilkAndSprinkle.Cost(), 1.70);
        }


    }
}
using Pokemon.SupportingObjects.Enums;
using Pokemon.SupportingObjects.Factory.GrowthRate;
using Pokemon.SupportingObjects.Factory.GrowthRate.Interfaces;

namespace PokemonTest
{
    public class GrowthRateTests
    {
        private GrowthRateFactory factory;

        [SetUp]
        public void Setup()
        {
            factory = new GrowthRateFactory();
        }

        [Test]
        public void TestMediumFastGrowthRate()
        {
            IGrowthRate growthRateObject = factory.GetGrowthRateCalculationObject(GrowthRate.MEDIUM_FAST);
            Assert.IsNotNull(growthRateObject);

            long exp0 = growthRateObject.Calculate(1);
            Assert.AreEqual(0, exp0);
            long exp1 = growthRateObject.Calculate(5);
            Assert.AreEqual(exp1, 125);
            long exp2 = growthRateObject.Calculate(25);
            Assert.AreEqual(exp2, 15625);
            long exp3 = growthRateObject.Calculate(100);
            Assert.AreEqual(exp3, 1000000);
        }

        [Test]
        public void TestMediumSlowGrowthRate()
        {
            IGrowthRate growthRateObject = factory.GetGrowthRateCalculationObject(GrowthRate.MEDIUM_SLOW);
            Assert.IsNotNull(growthRateObject);

            long exp0 = growthRateObject.Calculate(1);
            Assert.AreEqual(0, exp0);
            long exp1 = growthRateObject.Calculate(5);
            Assert.AreEqual(exp1, 135);
            long exp2 = growthRateObject.Calculate(25);
            Assert.AreEqual(exp2, 11735);
            long exp3 = growthRateObject.Calculate(100);
            Assert.AreEqual(exp3, 1059860);
        }

        [Test]
        public void TestFastGrowthRate()
        {
            IGrowthRate growthRateObject = factory.GetGrowthRateCalculationObject(GrowthRate.FAST);
            Assert.IsNotNull(growthRateObject);

            long exp0 = growthRateObject.Calculate(1);
            Assert.AreEqual(0, exp0);
            long exp1 = growthRateObject.Calculate(5);
            Assert.AreEqual(exp1, 100);
            long exp2 = growthRateObject.Calculate(25);
            Assert.AreEqual(exp2, 12500);
            long exp3 = growthRateObject.Calculate(100);
            Assert.AreEqual(exp3, 800000);
        }

        [Test]
        public void TestSlowGrowthRate()
        {
            IGrowthRate growthRateObject = factory.GetGrowthRateCalculationObject(GrowthRate.SLOW);
            Assert.IsNotNull(growthRateObject);

            long exp0 = growthRateObject.Calculate(1);
            Assert.AreEqual(0, exp0);
            long exp1 = growthRateObject.Calculate(5);
            Assert.AreEqual(exp1, 156);    
            long exp2 = growthRateObject.Calculate(25);
            Assert.AreEqual(exp2, 19531);
            long exp3 = growthRateObject.Calculate(100);
            Assert.AreEqual(exp3, 1250000);
        }



        [Test]
        public void TestErraticGrowthRate()
        {
            IGrowthRate growthRateObject = factory.GetGrowthRateCalculationObject(GrowthRate.ERRATIC);
            Assert.IsNotNull(growthRateObject);

            long exp0 = growthRateObject.Calculate(1);
            Assert.AreEqual(0, exp0);
            long exp1 = growthRateObject.Calculate(5);
            Assert.AreEqual(237, exp1);
            long exp2 = growthRateObject.Calculate(25);
            Assert.AreEqual(23437, exp2);
            long exp3 = growthRateObject.Calculate(50);
            Assert.AreEqual(125000, exp3);
            long exp4 = growthRateObject.Calculate(51);
            Assert.AreEqual(131324, exp4);
            long exp5 = growthRateObject.Calculate(68);
            Assert.AreEqual(257834, exp5);
            long exp6 = growthRateObject.Calculate(69);
            Assert.AreEqual(267406, exp6);
            long exp7 = growthRateObject.Calculate(98);
            Assert.AreEqual(583539, exp7);
            long exp8 = growthRateObject.Calculate(100);
            Assert.AreEqual(600000 ,exp8);
        }



        [Test]
        public void TestFluctuatingGrowthRate()
        {
            IGrowthRate growthRateObject = factory.GetGrowthRateCalculationObject(GrowthRate.FLUCTUATING);
            Assert.IsNotNull(growthRateObject);

            long exp0 = growthRateObject.Calculate(1);
            Assert.AreEqual(0, exp0);
            long exp1 = growthRateObject.Calculate(5);
            Assert.AreEqual(65, exp1);
            long exp2 = growthRateObject.Calculate(15);
            Assert.AreEqual(1957, exp2);
            long exp3 = growthRateObject.Calculate(16);
            Assert.AreEqual(2457, exp3);
            long exp4 = growthRateObject.Calculate(36);
            Assert.AreEqual(46656, exp4);
            long exp5 = growthRateObject.Calculate(37);
            Assert.AreEqual(50653, exp5);
            long exp6 = growthRateObject.Calculate(100);
            Assert.AreEqual(1640000, exp6);
        }
    }
}

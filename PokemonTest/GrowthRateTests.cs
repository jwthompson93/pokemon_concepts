using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTest
{
    public class GrowthRateTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMediumFastGrowthRate()
        {
            long exp1 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(5, GrowthRate.MEDIUM_FAST);
            Assert.IsTrue(exp1.Equals(125));
            long exp2 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(25, GrowthRate.MEDIUM_FAST);
            Assert.IsTrue(exp2.Equals(15625));
            long exp3 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(100, GrowthRate.MEDIUM_FAST);
            Assert.IsTrue(exp3.Equals(1000000));
        }

        [Test]
        public void TestMediumSlowGrowthRate()
        {
            long exp1 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(5, GrowthRate.MEDIUM_SLOW);
            Assert.IsTrue(exp1.Equals(135));
            long exp2 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(25, GrowthRate.MEDIUM_SLOW);
            Assert.IsTrue(exp2.Equals(11735));
            long exp3 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(100, GrowthRate.MEDIUM_SLOW);
            Assert.IsTrue(exp3.Equals(1059860));
        }

        [Test]
        public void TestFastGrowthRate()
        {
            long exp1 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(5, GrowthRate.FAST);
            Assert.IsTrue(exp1.Equals(100));
            long exp2 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(25, GrowthRate.FAST);
            Assert.IsTrue(exp2.Equals(12500));
            long exp3 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(100, GrowthRate.FAST);
            Assert.IsTrue(exp3.Equals(800000));
        }

        [Test]
        public void TestSlowGrowthRate()
        {
            long exp1 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(5, GrowthRate.SLOW);
            Assert.IsTrue(exp1.Equals(156));
            long exp2 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(25, GrowthRate.SLOW);
            Assert.IsTrue(exp2.Equals(19531));
            long exp3 = GrowthRateSingleton.GetInstance().CalculateGrowthRateUntilNextLevel(100, GrowthRate.SLOW);
            Assert.IsTrue(exp3.Equals(1250000));
        }
    }
}

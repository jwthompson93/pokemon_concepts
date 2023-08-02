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
            long exp0 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(1, GrowthRate.MEDIUM_FAST);
            Assert.AreEqual(0, exp0);
            long exp1 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(5, GrowthRate.MEDIUM_FAST);
            Assert.IsTrue(exp1.Equals(125));
            long exp2 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(25, GrowthRate.MEDIUM_FAST);
            Assert.IsTrue(exp2.Equals(15625));
            long exp3 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(100, GrowthRate.MEDIUM_FAST);
            Assert.IsTrue(exp3.Equals(1000000));
        }

        [Test]
        public void TestMediumSlowGrowthRate()
        {
            long exp0 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(1, GrowthRate.MEDIUM_SLOW);
            Assert.AreEqual(0, exp0);
            long exp1 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(5, GrowthRate.MEDIUM_SLOW);
            Assert.IsTrue(exp1.Equals(135));
            long exp2 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(25, GrowthRate.MEDIUM_SLOW);
            Assert.IsTrue(exp2.Equals(11735));
            long exp3 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(100, GrowthRate.MEDIUM_SLOW);
            Assert.IsTrue(exp3.Equals(1059860));
        }

        [Test]
        public void TestFastGrowthRate()
        {

            long exp0 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(1, GrowthRate.FAST);
            Assert.AreEqual(0, exp0);
            long exp1 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(5, GrowthRate.FAST);
            Assert.IsTrue(exp1.Equals(100));
            long exp2 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(25, GrowthRate.FAST);
            Assert.IsTrue(exp2.Equals(12500));
            long exp3 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(100, GrowthRate.FAST);
            Assert.IsTrue(exp3.Equals(800000));
        }

        [Test]
        public void TestSlowGrowthRate()
        {
            long exp0 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(1, GrowthRate.SLOW);
            Assert.AreEqual(0, exp0);
            long exp1 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(5, GrowthRate.SLOW);
            Assert.IsTrue(exp1.Equals(156));
            long exp2 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(25, GrowthRate.SLOW);
            Assert.IsTrue(exp2.Equals(19531));
            long exp3 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(100, GrowthRate.SLOW);
            Assert.IsTrue(exp3.Equals(1250000));
        }



        [Test]
        public void TestErraticGrowthRate()
        {
            long exp0 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(1, GrowthRate.ERRATIC);
            Assert.AreEqual(0, exp0);
            long exp1 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(5, GrowthRate.ERRATIC);
            Assert.AreEqual(237, exp1);
            long exp2 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(25, GrowthRate.ERRATIC);
            Assert.AreEqual(23437, exp2);
            long exp3 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(50, GrowthRate.ERRATIC);
            Assert.AreEqual(125000, exp3);
            long exp4 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(51, GrowthRate.ERRATIC);
            Assert.AreEqual(131324, exp4);
            long exp5 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(68, GrowthRate.ERRATIC);
            Assert.AreEqual(257834, exp5);
            long exp6 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(69, GrowthRate.ERRATIC);
            Assert.AreEqual(267406, exp6);
            long exp7 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(98, GrowthRate.ERRATIC);
            Assert.AreEqual(583539, exp7);
            long exp8 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(100, GrowthRate.ERRATIC);
            Assert.AreEqual(600000 ,exp8);
        }



        [Test]
        public void TestFluctuatingGrowthRate()
        {
            long exp0 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(1, GrowthRate.FLUCTUATING);
            Assert.AreEqual(0, exp0);
            long exp1 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(5, GrowthRate.FLUCTUATING);
            Assert.AreEqual(65, exp1);
            long exp2 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(15, GrowthRate.FLUCTUATING);
            Assert.AreEqual(1957, exp2);
            long exp3 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(16, GrowthRate.FLUCTUATING);
            Assert.AreEqual(2457, exp3);
            long exp4 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(36, GrowthRate.FLUCTUATING);
            Assert.AreEqual(46656, exp4);
            long exp5 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(37, GrowthRate.FLUCTUATING);
            Assert.AreEqual(50653, exp5);
            long exp6 = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(100, GrowthRate.FLUCTUATING);
            Assert.AreEqual(1640000, exp6);
        }
    }
}

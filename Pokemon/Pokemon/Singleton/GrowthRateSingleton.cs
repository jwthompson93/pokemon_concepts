using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon.Pokemon.Constants;

namespace Pokemon.Pokemon.Singleton
{
    public class GrowthRateSingleton
    {
        private static GrowthRateSingleton _instance;

        private GrowthRateSingleton() { }

        public static GrowthRateSingleton GetInstance()
        {
            if (_instance == null)
                _instance = new GrowthRateSingleton();

            return _instance;
        }

        // Selects the correct growth rate and calculates the exp based on the level
        public long CalculateGrowthRateUntilNextLevel(int level, GrowthRate growthRate)
        {
            switch (growthRate)
            {
                case GrowthRate.MEDIUM_SLOW:
                    return MediumSlowGrowthRate(level);
                case GrowthRate.MEDIUM_FAST:
                    return MediumFastGrowthRate(level);
                case GrowthRate.FAST:
                    return FastGrowthRate(level);
                case GrowthRate.SLOW:
                    return SlowGrowthRate(level);
                default:
                    return 0;
            }
        }

        private long MediumSlowGrowthRate(long level)
        {
            return (long)(1.2 * Math.Pow(level, 3) - 15 * Math.Pow(level, 2) + 100 * level - 140);
        }

        private long MediumFastGrowthRate(long level)
        {
            return (long)Math.Pow(level, 3);
        }

        private long SlowGrowthRate(long level)
        {
            return (long)(5 * Math.Pow(level, 3) / 4);
        }

        private long FastGrowthRate(long level)
        {
            return (long)(4 * Math.Pow(level, 3) / 5);
        }
    }
}

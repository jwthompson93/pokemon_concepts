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
            long experience = 0L;


            // This is included as the MEDIUM_SLOW algorithm with a level = 1 returns -53
            // Also, the FAST and SLOW algorithms will return 1 so there needed to be a check for that too
            if (level == 1) { 
                return experience;
            }

            switch (growthRate)
            {
                case GrowthRate.MEDIUM_SLOW:
                    experience = MediumSlowGrowthRate(level);
                    break;
                case GrowthRate.MEDIUM_FAST:
                    experience = MediumFastGrowthRate(level);
                    break;
                case GrowthRate.FAST:
                    experience = FastGrowthRate(level);
                    break;
                case GrowthRate.SLOW:
                    experience = SlowGrowthRate(level);
                    break;
                case GrowthRate.ERRATIC:
                    experience = ErraticGrowthRate(level);
                    break;
                default:
                    experience = 0L;
                    break;
            }

            return experience;
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

        private long ErraticGrowthRate(long level)
        {
            long experience = 0L;

            if (level <= 50)
            {
                experience = (long)((Math.Pow(level, 3) * (100 - level)) / 50);
            }

            if (level > 50)
            {
                experience = (long)((Math.Pow(level, 3) * (150 - level) / 100));
            }

            if (level > 68)
            {
                experience = (long)((Math.Pow(level, 3) * ((1911 - (10 * level)) / 3)) / 500);
            }

            if (level > 98)
            {
                experience = (long)(Math.Pow(level, 3) * (160 - level) / 100);
            }

            return experience;
        }
    }
}

using Pokemon.Enums;

namespace Pokemon.Singleton
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
        public int CalculateExperienceAtLevel(int level, GrowthRate growthRate)
        {
            int experience = 0;


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
                case GrowthRate.FLUCTUATING:
                    experience = FluctuatingGrowthRate(level);
                    break;
                default:

                    break;
            }

            return experience;
        }

        private int MediumSlowGrowthRate(int level)
        {
            return (int)(1.2 * Math.Pow(level, 3) - 15 * Math.Pow(level, 2) + 100 * level - 140);
        }

        private int MediumFastGrowthRate(int level)
        {
            return (int)Math.Pow(level, 3);
        }

        private int SlowGrowthRate(int level)
        {
            return (int)(5 * Math.Pow(level, 3) / 4);
        }

        private int FastGrowthRate(int level)
        {
            return (int)(4 * Math.Pow(level, 3) / 5);
        }

        private int ErraticGrowthRate(int level)
        {
            int experience = 0;

            if (level <= 50)
            {
                experience = (int)((Math.Pow(level, 3) * (100 - level)) / 50);
            }

            if (level > 50 && level <= 68)
            {
                experience = (int)((Math.Pow(level, 3) * (150 - level) / 100));
            }

            if (level > 68 && level <= 98)
            {
                experience = (int)((Math.Pow(level, 3) * ((1911 - (10 * level)) / 3)) / 500);
            }

            if (level > 98)
            {
                experience = (int)(Math.Pow(level, 3) * (160 - level) / 100);
            }

            return experience;
        }

        private int FluctuatingGrowthRate(int level)
        {
            int experience = 0;

            if (level <= 15)
            {
                experience = (int)(Math.Pow(level, 3) * (((level + 1) / 3) + 24)) / 50;
            }

            if (level > 15 && level <= 36)
            {
                experience = (int)((Math.Pow(level, 3) * (level + 14)) / 50);
            }

            if (level > 36)
            {
                experience = (int)((Math.Pow(level, 3) * ((level / 2) + 32)) / 50);
            }

            return experience;
        }
    }
}

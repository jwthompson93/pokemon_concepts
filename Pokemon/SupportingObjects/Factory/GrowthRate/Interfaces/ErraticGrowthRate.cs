namespace Pokemon.SupportingObjects.Factory.GrowthRate.Interfaces
{
    internal class ErraticGrowthRate : IGrowthRate
    {
        public override int GrowthRateCalculation(int level)
        {
            int experience = 0;

            if (level <= 50)
            {
                experience = (int)(Math.Pow(level, 3) * (100 - level) / 50);
            }

            if (level > 50 && level <= 68)
            {
                experience = (int)(Math.Pow(level, 3) * (150 - level) / 100);
            }

            if (level > 68 && level <= 98)
            {
                experience = (int)(Math.Pow(level, 3) * ((1911 - 10 * level) / 3) / 500);
            }

            if (level > 98)
            {
                experience = (int)(Math.Pow(level, 3) * (160 - level) / 100);
            }

            return experience;
        }
    }
}

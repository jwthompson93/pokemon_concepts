namespace Pokemon.Factory.GrowthRate
{
    internal class FluctuatingGrowthRate : IGrowthRate
    {
        public override int GrowthRateCalculation(int level)
        {
            int experience = 0;

            if (level <= 15)
            {
                experience = (int)(Math.Pow(level, 3) * ((level + 1) / 3 + 24)) / 50;
            }

            if (level > 15 && level <= 36)
            {
                experience = (int)(Math.Pow(level, 3) * (level + 14) / 50);
            }

            if (level > 36)
            {
                experience = (int)(Math.Pow(level, 3) * (level / 2 + 32) / 50);
            }

            return experience;
        }
    }
}

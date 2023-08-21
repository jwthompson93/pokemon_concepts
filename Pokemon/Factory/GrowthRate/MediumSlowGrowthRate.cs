namespace Pokemon.Factory.GrowthRate
{
    internal class MediumSlowGrowthRate : IGrowthRate
    {
        public override int GrowthRateCalculation(int level)
        {
            return (int)(1.2 * Math.Pow(level, 3) - 15 * Math.Pow(level, 2) + 100 * level - 140);
        }
    }
}

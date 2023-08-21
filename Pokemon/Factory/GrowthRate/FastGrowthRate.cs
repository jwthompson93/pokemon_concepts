namespace Pokemon.Factory.GrowthRate
{
    internal class FastGrowthRate : IGrowthRate
    {
        public override int GrowthRateCalculation(int level)
        {
            return (int)(4 * Math.Pow(level, 3) / 5);
        }
    }
}

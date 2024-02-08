namespace Pokemon.SupportingObjects.Factory.GrowthRate.Interfaces
{
    internal class SlowGrowthRate : IGrowthRate
    {
        public override int GrowthRateCalculation(int level)
        {
            return (int)(5 * Math.Pow(level, 3) / 4);
        }
    }
}

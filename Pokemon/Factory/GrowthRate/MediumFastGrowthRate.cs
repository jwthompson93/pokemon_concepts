namespace Pokemon.Factory.GrowthRate
{
    internal class MediumFastGrowthRate : IGrowthRate
    {
        public override int GrowthRateCalculation(int level)
        {
            return (int)Math.Pow(level, 3);
        }
    }
}

namespace Pokemon.SupportingObjects.Factory.GrowthRate.Interfaces
{
    public abstract class IGrowthRate
    {
        public abstract int GrowthRateCalculation(int level);

        public int Calculate(int level)
        {
            return level <= 1 ? 0 : GrowthRateCalculation(level);
        }
    }
}

using Pokemon.SupportingObjects.Factory.GrowthRate.Interfaces;

namespace Pokemon.SupportingObjects.Factory.GrowthRate
{
    public class GrowthRateFactory
    {

        // Selects the correct growth rate and calculates the exp based on the level
        public IGrowthRate GetGrowthRateCalculationObject(Enums.GrowthRate growthRateEnum)
        {
            IGrowthRate growthRate = null;

            switch (growthRateEnum)
            {
                case Enums.GrowthRate.MEDIUM_SLOW:
                    growthRate = new MediumSlowGrowthRate();
                    break;
                case Enums.GrowthRate.MEDIUM_FAST:
                    growthRate = new MediumFastGrowthRate();
                    break;
                case Enums.GrowthRate.FAST:
                    growthRate = new FastGrowthRate();
                    break;
                case Enums.GrowthRate.SLOW:
                    growthRate = new SlowGrowthRate();
                    break;
                case Enums.GrowthRate.ERRATIC:
                    growthRate = new ErraticGrowthRate();
                    break;
                case Enums.GrowthRate.FLUCTUATING:
                    growthRate = new FluctuatingGrowthRate();
                    break;
                default:

                    break;
            }

            return growthRate;
        }
    }
}

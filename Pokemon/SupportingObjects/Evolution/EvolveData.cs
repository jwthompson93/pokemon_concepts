namespace Pokemon.SupportingObjects.Evolution
{
    public class EvolveData
    {
        public int EvolveIntoPokemonId;
        public EvolveMethodEnum EvolveMethodType;
        public IEvolveMethod EvolveMethod { get; }
    }
}

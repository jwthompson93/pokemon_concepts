namespace Pokemon.SupportingObjects.Evolution
{
    public class LevelUpMethod : IEvolveMethod
    {
        public int _evolutionLevel { get; }
        public bool _setEvolveFlag;

        public LevelUpMethod(int _evolutionLevel) { 
            this._evolutionLevel = _evolutionLevel;
        }

        public void Evolve()
        {

        }
    }
}

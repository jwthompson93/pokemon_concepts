namespace Pokemon.Evolution
{
    public class LevelUpMethod : IEvolveMethod
    {
        private int _evolutionLevel { get; }
        private bool _setEvolveFlag;

        public LevelUpMethod(int _evolutionLevel) { 
            this._evolutionLevel = _evolutionLevel;
        }


        public void Evolve()
        {

        }
    }
}

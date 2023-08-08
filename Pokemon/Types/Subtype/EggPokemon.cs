using Pokemon.Enums;

namespace Pokemon.Types.Subtype
{
    public class EggPokemon : ActivePokemon
    {
        private Random _random = new Random();

        public EggPokemon(int id) : base(id, 1, false)
        {
            InitialIvs = new Stats(
                _random.Next(0, 31),
                _random.Next(0, 31),
                _random.Next(0, 31),
                _random.Next(0, 31),
                _random.Next(0, 31),
                _random.Next(0, 31)
            );
            Evs = new Stats(0, 0, 0, 0, 0, 0);
        }
    }
}

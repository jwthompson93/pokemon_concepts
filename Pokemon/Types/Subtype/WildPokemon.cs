using Pokemon.Constants;

namespace Pokemon.Types.Subtype
{
    public class WildPokemon : ActivePokemon
    {
        private Random _random = new Random(); // Remove once completed

        public WildPokemon(int pokemonId, int level) : base(pokemonId, level, true)
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

        public new string PrintPokemon()
        {
            return base.PrintPokemon();
        }
    }
}

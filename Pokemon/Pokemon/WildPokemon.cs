using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Types;

namespace Pokemon.Pokemon
{
    public class WildPokemon : ActivePokemon
    {
        private Random _random = new Random(); // Remove once completed

        public WildPokemon(int pokemonId, int level, bool isCatchable) : base(pokemonId, level, isCatchable)
        {
            this.InitialIvs = new Stats(
                _random.Next(0, 31),
                _random.Next(0, 31),
                _random.Next(0, 31),
                _random.Next(0, 31),
                _random.Next(0, 31),
                _random.Next(0, 31)
            );
            this.Evs = new Stats(0, 0, 0, 0, 0, 0);
        }

        public new string PrintPokemon()
        {
            return base.PrintPokemon();
        }
    }
}

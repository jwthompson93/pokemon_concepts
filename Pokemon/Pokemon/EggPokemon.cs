using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class EggPokemon : ActivePokemon
    {
        private Random _random = new Random();

        public EggPokemon(int id) : base(id, 1, false) {
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
    }
}

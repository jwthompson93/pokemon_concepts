using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class OwnedPokemon : ActivePokemon
    {
        public OwnedPokemon() {
            isCatchable = false;
        }

        public ActivePokemon activePokemon { get; set; }
        public Stats currentIvs { get; set; }
        public long exp { get; set; }
        public long expForCurrentLevel { get; set; }
        public long expForNextLevel { get; set; }

        public void gainExp(long expGained)
        {
            exp += expGained;
            if (exp > expForNextLevel)
            {
                levelUp();
                
                // How would we set experience until next level
                // Experience - Experience for current level ?
                expForNextLevel = exp;
            }
        }

        private void levelUp()
        {
            activePokemon.level += 1;
        }
    }
}

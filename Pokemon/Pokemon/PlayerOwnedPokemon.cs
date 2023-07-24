using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Types;

namespace Pokemon.Pokemon
{
    public class PlayerOwnedPokemon
    {
        public PlayerOwnedPokemon(ActivePokemon activePokemon) {
            this.ActivePokemon = activePokemon;
            this.ActivePokemon.IsCatchable = false;
        }

        public ActivePokemon ActivePokemon { get; set; }
        public Stats CurrentIvs { get; set; }
        public long Exp { get; set; }
        public long ExpForCurrentLevel { get; set; }
        public long ExpForNextLevel { get; set; }

        public void GainExp(long expGained)
        {
            Exp += expGained;
            if (Exp > ExpForNextLevel)
            {
                LevelUp();
                
                // How would we set experience until next level
                // Experience - Experience for current level ?
                ExpForNextLevel = Exp;
            }
        }

        private void LevelUp()
        {
            ActivePokemon.Level += 1;
        }
    }
}

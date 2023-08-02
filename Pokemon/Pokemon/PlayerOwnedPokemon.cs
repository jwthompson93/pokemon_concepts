using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Singleton;
using Pokemon.Pokemon.Types;

namespace Pokemon.Pokemon
{
    public class PlayerOwnedPokemon : ActivePokemon
    {
        public PlayerOwnedPokemon(int pokemonId, Stats initialIvs, Stats evs, int level, bool isCatchable) : base(pokemonId, initialIvs, evs, level, isCatchable) {
            this.IsCatchable = false;
            this.Exp = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(this.Level, this.BasePokemon.GrowthRate);
        }

        public Stats CurrentIvs { get; set; }
        public int Exp { get; set; }

        public void GainExp(int expGained)
        {
            Console.WriteLine($"{this.BasePokemon.Name} gained {expGained} exp");
            Exp += expGained;
            while (Exp >= GrowthRateSingleton.GetInstance()
                .CalculateExperienceAtLevel(this.Level + 1, this.BasePokemon.GrowthRate) && this.Level < 100)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            this.Level += 1;
            Console.WriteLine($"{this.BasePokemon.Name} reached Level {this.Level}");
        }

        public new string PrintPokemon()
        {
            return
                base.PrintPokemon() +
                $"Current IVs\t{this.CurrentIvs.PrintStats()}\n" +
                $"Total Exp\t{this.Exp}\n";
        }
    }
}

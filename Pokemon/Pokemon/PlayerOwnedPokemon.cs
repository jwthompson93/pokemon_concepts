using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Types;

namespace Pokemon.Pokemon
{
    public class PlayerOwnedPokemon
    {
        public PlayerOwnedPokemon(ActivePokemon activePokemon) {
            this.ActivePokemon = activePokemon;
            this.ActivePokemon.IsCatchable = false;
            this.Exp = GrowthRateConstants.GetInstance().CalculateGrowthRateUntilNextLevel(activePokemon.Level, activePokemon.BasePokemon.GrowthRate); ;
        }

        public ActivePokemon ActivePokemon { get; set; }
        public Stats CurrentIvs { get; set; }
        public long Exp { get; set; }

        public void GainExp(long expGained)
        {
            Console.WriteLine($"{ActivePokemon.BasePokemon.Name} gained {expGained} exp");
            Exp += expGained;
            while (Exp > GrowthRateConstants.GetInstance()
                .CalculateGrowthRateUntilNextLevel(ActivePokemon.Level + 1, ActivePokemon.BasePokemon.GrowthRate) && ActivePokemon.Level < 100)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            ActivePokemon.Level += 1;
            Console.WriteLine($"{ActivePokemon.BasePokemon.Name} reached Level {ActivePokemon.Level}");
        }

        public string PrintPokemon()
        {
            return
                this.ActivePokemon.PrintPokemon() +
                $"Current IVs\t{this.CurrentIvs.PrintStats()}\n" +
                $"Total Exp\t{this.Exp}\n";
        }
    }
}

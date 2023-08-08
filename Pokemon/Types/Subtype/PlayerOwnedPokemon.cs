using Pokemon.Enums;
using Pokemon.Singleton;

namespace Pokemon.Types.Subtype
{
    public class PlayerOwnedPokemon : ActivePokemon
    {
        public PlayerOwnedPokemon(int pokemonId, Stats initialIvs, Stats evs, int level, bool isCatchable) : base(pokemonId, initialIvs, evs, level, isCatchable)
        {
            IsCatchable = false;
            Exp = GrowthRateSingleton.GetInstance().CalculateExperienceAtLevel(Level, BasePokemon.GrowthRate);
        }

        public Stats CurrentIvs { get; set; }
        public int Exp { get; set; }

        public void GainExp(int expGained)
        {
            Console.WriteLine($"{BasePokemon.Name} gained {expGained} exp");
            Exp += expGained;
            while (Exp >= GrowthRateSingleton.GetInstance()
                .CalculateExperienceAtLevel(Level + 1, BasePokemon.GrowthRate) && Level < 100)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            Level += 1;
            Console.WriteLine($"{BasePokemon.Name} reached Level {Level}");
        }

        public new string PrintPokemon()
        {
            return
                base.PrintPokemon() +
                $"Current IVs\t{CurrentIvs.PrintStats()}\n" +
                $"Total Exp\t{Exp}\n";
        }
    }
}

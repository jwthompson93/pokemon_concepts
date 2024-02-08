
using Pokemon.SupportingObjects.Enums;
using Pokemon.SupportingObjects.Factory.GrowthRate;
using Pokemon.SupportingObjects.Factory.GrowthRate.Interfaces;
using Pokemon.SupportingObjects.Struct;

namespace Pokemon.Types.Subtype
{
    public class PlayerOwnedPokemon : ActivePokemon
    {
        public PlayerOwnedPokemon(int pokemonId, Stats initialIvs, Stats evs, int level, Nature nature, bool isCatchable) : base(pokemonId, initialIvs, evs, level, nature, isCatchable)
        {
            IsCatchable = false;
            growthRate = new GrowthRateFactory().GetGrowthRateCalculationObject(BasePokemon.GrowthRate);
            Exp = growthRate.Calculate(Level);
        }

        public Stats CurrentIvs { get; set; }
        public int Exp { get; set; }

        // Not sure about this. Set values might be preferable
        public IGrowthRate growthRate { get; set; }

        public void GainExp(int expGained)
        {
            Console.WriteLine($"{BasePokemon.Name} gained {expGained} exp");
            Exp += expGained;
            while (Exp >= growthRate.Calculate(Level + 1) && Level < 100)
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

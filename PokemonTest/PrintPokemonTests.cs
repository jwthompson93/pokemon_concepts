using Pokemon.Pokemon;
using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Types;

namespace PokemonTest
{
    public class PrintPokemonTests
    {
        private BasePokemon basePokemon;
        private ActivePokemon activePokemon;
        private WildPokemon wildPokemon;
        private PlayerOwnedPokemon playerOwnedPokemon;

        [SetUp]
        public void Setup()
        {
            basePokemon = PokemonConstants.GetInstance().GetPokemon(1);
            wildPokemon = new WildPokemon(1, 5);
            playerOwnedPokemon = new PlayerOwnedPokemon(wildPokemon.BasePokemon.Id, wildPokemon.InitialIvs, wildPokemon.Evs, wildPokemon.Level, false);
        }

        [Test]
        public void TestPrintBasePokemon()
        {
            Console.WriteLine(basePokemon.PrintPokemon());
            Assert.Pass();
        }

        [Test]
        public void TestPrintWildPokemon()
        {
            Console.WriteLine(wildPokemon.PrintPokemon());
            Assert.Pass();
        }

        [Test]
        public void TestPrintPlayerOwnedPokemon()
        {
            Console.WriteLine(playerOwnedPokemon.PrintPokemon());
            Assert.Pass();
        }
    }
}
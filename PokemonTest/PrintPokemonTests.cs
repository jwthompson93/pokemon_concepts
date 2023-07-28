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
            activePokemon = new ActivePokemon(1, new Stats(12, 13, 16, 6, 21, 31), new Stats(), 5, true);
            wildPokemon = new WildPokemon(1, 5);
            playerOwnedPokemon = new PlayerOwnedPokemon(wildPokemon.ActivePokemon);
        }

        [Test]
        public void TestPrintBasePokemon()
        {
            Console.WriteLine(basePokemon.PrintPokemon());
            Assert.Pass();
        }

        [Test]
        public void TestPrintActivePokemon()
        {
            Console.WriteLine(activePokemon.PrintPokemon());
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
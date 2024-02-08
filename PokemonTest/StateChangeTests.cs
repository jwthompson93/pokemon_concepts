using Pokemon.SupportingObjects.Singleton;
using Pokemon.Types.Subtype;

namespace PokemonTest
{
    public class StateChangeTests
    {
        private WildPokemon wildPokemon;
        private EggPokemon eggPokemon;

        [SetUp] 
        public void SetUp() {
            wildPokemon = new WildPokemon(1, 5);
            eggPokemon = new EggPokemon(1);
        }

        [Test]
        public void TestCatchWildPokemon() {
            PlayerOwnedPokemon playerOwnedPokemon = PokemonStateChangeSingleton.GetInstance().CaptureWildPokemon(wildPokemon);
            Console.WriteLine(playerOwnedPokemon.PrintPokemon());
            Assert.IsInstanceOf<PlayerOwnedPokemon>(playerOwnedPokemon);
        }

        [Test]
        public void TestHatchPokemon()
        {
            PlayerOwnedPokemon playerOwnedPokemon = PokemonStateChangeSingleton.GetInstance().HatchPokemon(eggPokemon);
            Console.WriteLine(playerOwnedPokemon.PrintPokemon());
            Assert.IsInstanceOf<PlayerOwnedPokemon>(playerOwnedPokemon);
        }
    }
}

using Pokemon.Pokemon.Constants;

namespace PokemonTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPrintBasePokemon()
        {
            Console.Write(PokemonConstants.GetInstance().GetPokemon(1).PrintPokemon());
            Assert.Pass();
        }
    }
}
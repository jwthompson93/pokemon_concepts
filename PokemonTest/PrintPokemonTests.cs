using Pokemon.Constants;
using Pokemon.Types;
using Pokemon.Types.Subtype;
using System.Text.Json;

namespace PokemonTest
{
    public class PrintPokemonTests
    {
        private BasePokemon _basePokemon;
        private WildPokemon _wildPokemon;
        private EggPokemon _eggPokemon;
        private PlayerOwnedPokemon _playerOwnedPokemon;

        [SetUp]
        public void Setup()
        {
            _basePokemon = PokemonConstants.GetInstance().GetPokemon(1);
            _wildPokemon = new WildPokemon(1, 5);
            _eggPokemon = new EggPokemon(1);
            _playerOwnedPokemon = new PlayerOwnedPokemon(_wildPokemon.BasePokemon.Id, _wildPokemon.InitialIvs, _wildPokemon.Evs, _wildPokemon.Level, _wildPokemon.Nature, false);
        }

        [Test]
        public void TestPrintBasePokemon()
        {
            Console.WriteLine(_basePokemon.PrintPokemon());
            Console.WriteLine(JsonSerializer.Serialize(_basePokemon));
            Assert.Pass();
        }

        [Test]
        public void TestPrintWildPokemon()
        {
            Console.WriteLine(_wildPokemon.PrintPokemon());
            Console.WriteLine(JsonSerializer.Serialize(_wildPokemon));
            Assert.Pass();
        }

        [Test]
        public void TestPrintEggPokemon()
        {
            Console.WriteLine(_eggPokemon.PrintPokemon());
            Console.WriteLine(JsonSerializer.Serialize(_eggPokemon));
            Assert.Pass();
        }

        [Test]
        public void TestPrintPlayerOwnedPokemon()
        {
            Console.WriteLine(_playerOwnedPokemon.PrintPokemon());
            Console.WriteLine(JsonSerializer.Serialize(_playerOwnedPokemon));
            Assert.Pass();
        }
    }
}
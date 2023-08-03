using Bag.Bag;
using PokemonBag.Bag;

namespace BagTest
{
    public class BagSlotTests
    {
        private BagSlots bagSlots;

        [SetUp]
        public void Setup()
        {
            bagSlots = new BagSlots();
            bagSlots.AddItemToBag(21, 1); // Bicycle - Key Item
            bagSlots.AddItemToBag(22, 1); // S.S. Ticket - Key Item
            bagSlots.AddItemToBag(11, 3); // Potion - Medicine Item
            bagSlots.AddItemToBag(12, 1); // Full Heal - Medicine Item

            bagSlots.AddItemToBag(1, 3); // Rare Candy - General Item
            bagSlots.AddItemToBag(2, 2); // Magmariser - General Item
            bagSlots.AddItemToBag(101, 2); // TM36: Selfdestruct - TM/HM Item
            bagSlots.AddItemToBag(102, 1); // TM08: Thunderbolt - TM/HM Item

            bagSlots.PrintBag();
        }

        [Test]
        public void TestAddNewItemToBag()
        {
            bagSlots.AddItemToBag(3, 1); // Destiny Knot - General Item
            Assert.AreEqual(bagSlots.GetItemBag(ItemType.GENERAL_ITEM)[3], 1);
        }

        [Test]
        public void TestAddExistingItemToBag()
        {
            bagSlots.AddItemToBag(11, 1); // Potion - Medicine Item
            Assert.AreEqual(bagSlots.GetItemBag(ItemType.MEDICINE_ITEM)[11], 4);
        }
    }
}
using Bag.Bag;
using Item.Constants;
using Item.Types;

namespace PokemonBag.Bag
{
    public class BagSlots
    {
        private Dictionary<ItemType, Dictionary<int, int>> slots;

        public BagSlots()
        {
            slots = new Dictionary<ItemType, Dictionary<int, int>>
            {
                { ItemType.GENERAL_ITEM, new Dictionary<int, int>() },
                { ItemType.MEDICINE_ITEM, new Dictionary<int, int>() },
                { ItemType.TMHM_ITEM, new Dictionary<int, int>() },
                { ItemType.KEY_ITEM, new Dictionary<int, int>() }
            };
        }

        public void AddItemToBag(int itemId)
        {
            AddItemToBag(itemId, 1);
        }

        public void AddItemToBag(int itemId, int quantity)
        {
            AItem item = ItemConstants.GetInstance().getItem(itemId);

            if (item is KeyItem) {
                CheckIfBagContainsItem(itemId, quantity, ItemType.KEY_ITEM);
            }
            else if (item is MedicineItem)
            {
                CheckIfBagContainsItem(itemId, quantity, ItemType.MEDICINE_ITEM);
            }
            else if (item is GeneralItem)
            {
                CheckIfBagContainsItem(itemId, quantity, ItemType.GENERAL_ITEM);
            }
            else if (item is TmHmItem)
            {
                CheckIfBagContainsItem(itemId, quantity, ItemType.TMHM_ITEM);
            }
        }

        private void CheckIfBagContainsItem(int itemId, int quantity, ItemType itemType) {
            if (slots[itemType].ContainsKey(itemId)) {
                slots[itemType][itemId] = slots[itemType][itemId] + quantity;
            }
            else
            {
                slots[itemType].Add(itemId, quantity);
            }
        }

        public Dictionary<int, int> GetItemBag(ItemType itemType)
        {
            return slots[itemType];
        }

        public void PrintBag()
        {
            foreach(ItemType itemType in slots.Keys)
            {
                foreach (int itemId in slots[itemType].Keys)
                {
                    Console.WriteLine("\t {0} \tx{1}", ItemConstants.GetInstance().getItem(itemId).Name, slots[itemType][itemId]);
                }
            }
        }
    }
}

using Item.Constants;
using Item.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBag.Bag
{
    public class BagSlots
    {

        private Dictionary<int, int> _keyItems;
        private Dictionary<int, int> _medicineItems;
        private Dictionary<int, int> _generalItems;
        private Dictionary<int, int> _tmHmItems;

        public BagSlots()
        {
            _keyItems = new Dictionary<int, int>();
            _medicineItems = new Dictionary<int, int>();
            _generalItems = new Dictionary<int, int>();
            _tmHmItems = new Dictionary<int, int>();
        }

        public void AddItemToBag(int itemId)
        {
            AddItemToBag(itemId, 1);
        }

        public void AddItemToBag(int itemId, int quantity)
        {
            AItem item = ItemConstants.GetInstance().getItem(itemId);

            if (item is KeyItem) {
                CheckIfBagContainsItem(itemId, quantity, ref _keyItems);
            }
            else if (item is MedicineItem)
            {
                CheckIfBagContainsItem(itemId, quantity, ref _medicineItems);
            }
            else if (item is GeneralItem)
            {
                CheckIfBagContainsItem(itemId, quantity, ref _generalItems);
            }
            else if (item is TmHmItem)
            {
                CheckIfBagContainsItem(itemId, quantity, ref _tmHmItems);
            }
        }

        private void CheckIfBagContainsItem(int itemId, int quantity, ref Dictionary<int, int> itemBag) {
            if (itemBag.ContainsKey(itemId)) {
                itemBag[itemId] = itemBag[itemId] + quantity;
            }
            else
            {
                itemBag.Add(itemId, quantity);
            }
        }

        public void PrintBag()
        {
            Console.WriteLine("General Items");
            foreach(int itemId in _generalItems.Keys) { 
                Console.WriteLine("\t {0} \tx{1}", ItemConstants.GetInstance().getItem(itemId).Name, _generalItems[itemId]);
            }
            Console.WriteLine("Medicine Items");
            foreach (int itemId in _medicineItems.Keys)
            {
                Console.WriteLine("\t {0} \tx{1}", ItemConstants.GetInstance().getItem(itemId).Name, _medicineItems[itemId]);
            }
            Console.WriteLine("TM/HM Items");
            foreach (int itemId in _tmHmItems.Keys)
            {
                Console.WriteLine("\t {0} \tx{1}", ItemConstants.GetInstance().getItem(itemId).Name, _tmHmItems[itemId]);
            }
            Console.WriteLine("Key Items");
            foreach (int itemId in _keyItems.Keys)
            {
                Console.WriteLine("\t {0} \tx{1}", ItemConstants.GetInstance().getItem(itemId).Name, _keyItems[itemId]);
            }
        }
    }
}

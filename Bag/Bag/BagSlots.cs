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
            _keyItems.Add(21, 1);
            _keyItems.Add(22, 1);

            _medicineItems = new Dictionary<int, int>();
            _medicineItems.Add(11, 3);
            _medicineItems.Add(12, 2);

            _generalItems = new Dictionary<int, int>();
            _generalItems.Add(1, 3);
            _generalItems.Add(2, 1);

            _tmHmItems = new Dictionary<int, int>();
            _tmHmItems.Add(101, 2);
            _tmHmItems.Add(102, 1);
        }

        public void AddItemToBag(int itemId)
        {
            AItem item = ItemConstants.GetInstance().getItem(itemId);

            if (item is KeyItem) {
                CheckIfBagContainsItem(itemId, ref _keyItems);
            }
            else if (item is MedicineItem)
            {
                CheckIfBagContainsItem(itemId, ref _medicineItems);
            }
            else if (item is GeneralItem)
            {
                CheckIfBagContainsItem(itemId, ref _generalItems);
            }
            else if (item is TmHmItem)
            {
                CheckIfBagContainsItem(itemId, ref _tmHmItems);
            }
        }

        private void CheckIfBagContainsItem(int itemId, ref Dictionary<int, int> itemBag) {
            if (itemBag.ContainsKey(itemId)) {
                itemBag[itemId]++;
            }
            else
            {
                itemBag.Add(itemId, 1);
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

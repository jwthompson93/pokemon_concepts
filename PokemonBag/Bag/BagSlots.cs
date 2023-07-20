using PokemonBag.Bag.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBag.Bag
{
    public class BagSlots
    {
        private static Dictionary<int, Item> items = new Dictionary<int, Item>
        {
            { 1, new GeneralItem(1, "Rare Candy", "") },
            { 2, new GeneralItem(2, "Magmariser", "")},
            { 3, new GeneralItem(3, "Destiny Knot", "") },
            { 11, new MedicineItem(11, "Potion", "") },
            { 12, new MedicineItem(12, "Full Heal", "") },
            { 21, new KeyItem(21, "Bicycle", "") },
            { 22, new KeyItem(22, "S.S. Ticket", "") },
            { 101, new TmHmItem(101, "TM36 Selfdestruct", "") },
            { 102, new TmHmItem(102, "TM08 Thunderbolt", "") },

        };

        private Dictionary<int, int> keyItems;
        private Dictionary<int, int> medicineItems;
        private Dictionary<int, int> generalItems;
        private Dictionary<int, int> tmHmItems;

        public BagSlots()
        {
            keyItems = new Dictionary<int, int>();
            keyItems.Add(21, 1);
            keyItems.Add(22, 1);

            medicineItems = new Dictionary<int, int>();
            medicineItems.Add(11, 3);
            medicineItems.Add(12, 2);

            generalItems = new Dictionary<int, int>();
            generalItems.Add(1, 3);
            generalItems.Add(2, 1);

            tmHmItems = new Dictionary<int, int>();
            tmHmItems.Add(101, 2);
            tmHmItems.Add(102, 1);
        }

        public void addItemToBag(int itemId)
        {
            if (items[itemId] is KeyItem) {
                checkIfBagContainsItem(itemId, ref keyItems);
            }
            else if (items[itemId] is MedicineItem)
            {
                checkIfBagContainsItem(itemId, ref medicineItems);
            }
            else if (items[itemId] is GeneralItem)
            {
                checkIfBagContainsItem(itemId, ref generalItems);
            }
            else if (items[itemId] is TmHmItem)
            {
                checkIfBagContainsItem(itemId, ref tmHmItems);
            }
        }

        private void checkIfBagContainsItem(int itemId, ref Dictionary<int, int> itemBag) {
            if (itemBag.ContainsKey(itemId)) {
                itemBag[itemId]++;
            }
            else
            {
                itemBag.Add(itemId, 1);
            }
        }

        public void printBag()
        {
            Console.WriteLine("General Items");
            foreach(int itemId in generalItems.Keys) { 
                Console.WriteLine("\t {0} \tx{1}", items[itemId].Name, generalItems[itemId]);
            }
            Console.WriteLine("Medicine Items");
            foreach (int itemId in medicineItems.Keys)
            {
                Console.WriteLine("\t {0} \tx{1}", items[itemId].Name, medicineItems[itemId]);
            }
            Console.WriteLine("TM/HM Items");
            foreach (int itemId in tmHmItems.Keys)
            {
                Console.WriteLine("\t {0} \tx{1}", items[itemId].Name, tmHmItems[itemId]);
            }
            Console.WriteLine("Key Items");
            foreach (int itemId in keyItems.Keys)
            {
                Console.WriteLine("\t {0} \tx{1}", items[itemId].Name, keyItems[itemId]);
            }
        }
    }
}

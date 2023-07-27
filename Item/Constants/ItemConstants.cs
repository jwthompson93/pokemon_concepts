using Item.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Constants
{
    public class ItemConstants
    {
        private static ItemConstants _instance;
        private static Dictionary<int, AItem> _items;

        private ItemConstants()
        {
            _items = new Dictionary<int, AItem>
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
        }

        public static ItemConstants GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ItemConstants();
            }

            return _instance;
        }

        public AItem getItem(int index)
        { 
            return _items[index]; 
        }
    }
}

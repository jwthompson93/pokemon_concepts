using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Types
{
    public class MedicineItem : AItem
    {
        public MedicineItem(int id, string name, string description) : base(id, name, description)
        {
        }
    }
}

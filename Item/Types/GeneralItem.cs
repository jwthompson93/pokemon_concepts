using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Types
{
    public class GeneralItem : AItem
    {
        public GeneralItem(int id, string name, string description) : base(id, name, description)
        {
        }
    }
}

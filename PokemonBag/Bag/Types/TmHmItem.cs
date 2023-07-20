using PokemonBag.Bag.Types.Subtype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBag.Bag.Types
{
    public class TmHmItem : Item, UsableItem
    {
        public TmHmItem(int id, string name, string description) : base(id, name, description)
        {
        }

        public void useItem()
        {
            throw new NotImplementedException();
        }
    }
}

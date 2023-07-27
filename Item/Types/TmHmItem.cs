using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Types
{
    public class TmHmItem : AItem
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

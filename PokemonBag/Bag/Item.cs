using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBag.Bag
{
    public abstract class Item
    {
        public Item(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
        public int Id { get; set; }
        public string Name { get; }
        public string Description { get; }
    }
}

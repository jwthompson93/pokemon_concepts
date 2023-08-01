using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Types
{
    public abstract class AItem
    {
        public AItem(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public int Id { get; set; }
        public string Name { get; }
        public string Description { get; }
    }
}

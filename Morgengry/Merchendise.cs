using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Morgengry
{

    public abstract class Merchendise : IValuable
    {
        public abstract double GetValue();
        
        public string ItemId { get; set; }

        //public Merchendise() {}
        public Merchendise(string itemId)
        {
            ItemId = itemId;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId;

        }
    }
}

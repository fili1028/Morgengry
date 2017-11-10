using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
   public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(Amulet itemId)
        {
            return itemId;
        }
        public double GetTotalValue()
        {
            double result = 0;

            foreach (Amulet item in amulets)
            {
                result = result + Utility.GetValueOfAmulet(item);
            }
            return result;
        }
    }
}

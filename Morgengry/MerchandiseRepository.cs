using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class MerchandiseRepository
    {
        private List<Merchendise> merchendiseList = new List<Merchendise>();
        public void AddMerchandise (Merchendise merch)
        {
            merchendiseList.Add(merch);
        }

        public Merchendise GetMerchendise(string itemId)
        {
            Merchendise retMerch = null;
            foreach (var merch in merchendiseList)
            {
                if(merch.ItemId == itemId)
                {
                    retMerch = merch;
                }


            }
            return retMerch;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (var merchendise in merchendiseList)
            {
                totalValue += Utility.GetValueOfMerchendise(merchendise);
            }
            return totalValue;
        }
    }

}



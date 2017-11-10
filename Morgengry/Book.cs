using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
   public class Book : Merchendise
    {
        public override double GetValue()
        {
            return Price;
        }
        public string Title { get; set; }
       public double Price { get; set; }

        public Book(string ItemId, string title, double price) : base(ItemId)
            
        {
           
            Title = title;
            Price = price;
        }

        
        public Book(string itemID, string title) :
            this (itemID, title, 0)
        {
           
        }
        public Book(string itemID) :

            this (itemID, "", 0)
            {
            }


        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price;  

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
   public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(Book itemID)
        {

            if (books.Contains(itemID))
            {
                foreach (Book item in books)
                {
                    return itemID;
                }
               
            }
            return null;


        }
        public double GetTotalValue()
        {
            double result = 0;

            foreach (Book item in books)
            {
                result = result + Utility.GetValueOfBook(item);
            }
            return result;
        }
    }
}

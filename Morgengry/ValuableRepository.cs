using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Morgengry
{
   public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

      public void Save()
        {
            StreamWriter writer;
            writer = new StreamWriter("ValuableRepository.txt");
            foreach (var valuable in valuables)
            {
                if (valuable is Book)
                {
                    Book b = (Book)valuable;
                    writer.WriteLine("Book;" + b.ItemId +";" + b.Title + ";" + b.Price); 
                    
                
                }
            if (valuables is Amulet)
            {
                Amulet a = (Amulet)valuable;
                    writer.WriteLine("Amulet;" + a.Quality + ";" + a.Design + ";" + a.Quality);
            }
            }
            writer.Close();

        }
    public void Save(string filename)
        {
            StreamWriter writer;
            writer = new StreamWriter(filename);
            writer.Write(valuables);
            writer.Close();
        }

        public void Load()
        {
            StreamReader reader = new StreamReader("ValuablesRepository.txt");
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }
        public void Load(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string ItemId) //TypeCasting
        {
            foreach (var valuable in valuables)
            {
                if (valuable is Book)
                {
                    Book b = (Book)valuable;
                    if (b.ItemId == ItemId)
                    {
                        return valuable;
                    }
                }
                if (valuable is Amulet)
                {
                    Amulet a = (Amulet)valuable;
                    if (a.ItemId == ItemId)
                    {
                        return valuable;
                    }

                }
                if (valuable is Course)
                {
                    Course c = (Course)valuable;
                    if (c.Name == ItemId)
                    {
                        return valuable;
                    }
                }

            } 
                return null;
        }
        public double GetTotalValue()
        {
            double result = 0;

            foreach (var valuable in valuables)
            {
                result = result + valuable.GetValue();
            }
            return result;
        }
        

        public int Count()
        {
            return valuables.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public static class Utility
    {
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;
        public static double CourseHourValue { get; set; } = 875.0;

        public static double GetValueOfMerchendise(Merchendise merchendise)
        {
            if (merchendise is Book book)
            {
                Book b = (Book)merchendise;
                return GetValueOfBook(book);
            }
            if (merchendise is Amulet amulet)
            {
                Amulet a = (Amulet)merchendise;
                return GetValueOfAmulet(amulet);

            }
            else return 0.0;
        }
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public static double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.Quality == Level.low)
                return 12.5;
            if (amulet.Quality == Level.medium)
                return 20.0;
            else
                return 27.5;
            

        }

        public static double GetValueOfCourse(Course course)
        {
           
            int numberOfHours = 0;
            numberOfHours = course.DurationInMinutes / 60;
            if (course.DurationInMinutes % 60 > 0)
            {
                numberOfHours++;
            }
            return numberOfHours * 875;

        }
    }
}

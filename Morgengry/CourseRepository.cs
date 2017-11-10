using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
   public class CourseRepository
    {
        private List<Course> courses = new List<Course>();
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course GetCourse(Course name)
        {
            return name;
        }
        public double GetTotalValue()
        {
            double result = 0;

            foreach (Course item in courses)
            {
                result = result + Utility.GetValueOfCourse(item);
            }
            return result;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
  public  class Course : IValuable
    {
        public double GetValue()
        {
            int timer = DurationInMinutes / 60;
            int restminutter = DurationInMinutes - (timer * 60);
            if (restminutter > 0)
                timer++;
            return timer * CourseHourValue;

        }
        public string Name { get; set; }
       public int DurationInMinutes { get; set; }
        public double CourseHourValue { get; set; } = 825.0;
        public Course(string name)
        {
            Name = name;
        }
        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes + ", Pris pr påbegyndt time: " + CourseHourValue;
        }

    }
}

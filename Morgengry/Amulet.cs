using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        low,
        medium,
        high
    };
    public class Amulet : Merchendise
    {
        public override double GetValue()
        {
            double result = 0;
            if (Quality == Level.high)
                result = HighQualityValue;
            if (Quality == Level.medium)
                result = MediumQualityValue;
            if (Quality == Level.low)
                result = LowQualityValue;
            return result;

        }
        public string Design { get; set; }

        public Level Quality { get; set; }
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;




        public Amulet(string itemId, Level quality, string design) : base(itemId)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId) :
            this(itemId, Level.medium, "")
        {
        }
        public Amulet(string itemId, Level Quality) :
        this(itemId, Quality, "")
        {
        }   
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
    }
}


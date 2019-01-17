using System;
using System.Collections.Generic;
using System.Linq;
using lab5.Candies;

namespace lab5.Gift
{
    public class Gift
    {
        public List<Candy> Candies { get; set; }
        public double Weight { get; private set; }

        public Gift()
        {
            Candies = new List<Candy>();
            Weight = 0;
        }

        public void Add(Candy candy)
        {
            Candies.Add(candy);
            Weight += candy.Weight;
        }

        public List<Candy> Sort(string property)
        {
            return Candies.OrderBy(p => p.GetType()
                               .GetProperty(property)
                               .GetValue(p, null)).ToList();
        }

        public List<Candy> FindBySugar(double minSugarWeight, double maxSugarWeight)
        {
            return Candies.Where(candy => candy.SugarWeight >= minSugarWeight && candy.SugarWeight <= maxSugarWeight).ToList();
        }
    }
}

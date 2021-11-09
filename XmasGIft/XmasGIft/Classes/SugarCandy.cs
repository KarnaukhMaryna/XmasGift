using System;

namespace XmasGIft.Classes
{
    class SugarCandy: Candy
    {
        
        public SugarCandy() : base()
        {
            Random rand = new Random();
            weight = rand.Next(20, 36);
        }

        public SugarCandy(int weight) : base() => this.weight = weight;

        public override string ToString()
        {
            return string.Format("SugarCandy's weight is {0}, taste {1}, colour is {2}", weight, taste, colour); ;
        }
    }
}

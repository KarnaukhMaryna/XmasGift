using System;

namespace XmasGIft.Classes
{
    class JellyCandy: Candy
    {
        
        public JellyCandy() : base()
        {
            Random rand = new Random();
            this.weight = rand.Next(8, 17);
        }

        public JellyCandy(int weight) : base() => this.weight = weight;

        public override string ToString()
        {
            return string.Format("JellyCandy's weight is {0}, taste {1}, colour is {2}", weight, taste, colour); ;
        }
    }
}

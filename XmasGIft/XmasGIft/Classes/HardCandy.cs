using System;

namespace XmasGIft.Classes
{
    class HardCandy: Candy
    {

        public HardCandy():base()
        {
            Random rand = new Random();
            this.weight = rand.Next(10, 21);                  
        }

        public HardCandy(int weight) : base() => this.weight = weight;
       
        public override string ToString()
        {
            return string.Format("HardCandy's weight is {0}, taste {1}, colour is {2}", weight, taste, colour); ;
        }

        

    }
}

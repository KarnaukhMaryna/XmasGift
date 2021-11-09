using System;
using XmasGIft.Classes;
using XmasGIft.Collection;

namespace XmasGIft
{
    class Program
    {
        static void Main(string[] args)
        {
            HardCandy h = new HardCandy();
            Console.WriteLine(h);
            SugarCandy s = new SugarCandy();
            Console.WriteLine(s);
            JellyCandy j = new JellyCandy();
            Console.WriteLine(j);

            CandiesCollection gift = new CandiesCollection{h,s,j};

            Console.WriteLine("");
            CandiesCollection.OutputOnDisplay(gift);


        }
    }
}

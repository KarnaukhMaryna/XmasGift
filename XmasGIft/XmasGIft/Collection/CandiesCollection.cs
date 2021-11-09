using System;
using System.Collections;
using XmasGIft.Classes;
using System.Linq;
using XmasGIft.Enum;

namespace XmasGIft.Collection
{
    class CandiesCollection: IEnumerable
    {
        private IList CandiesArray { get; }

        public CandiesCollection() => CandiesArray = new ArrayList();
       
        public int Count => CandiesArray.Count;

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < Count; index++)
            {
                yield return CandiesArray[index];
            }
        }

        public int Add(Candy candy) => CandiesArray.Add(candy);

        public void RemoveAt(int index) => CandiesArray.RemoveAt(index);

        public void Remove(Candy candy) => CandiesArray.Remove(candy);

        public int WeightOfXmasGift()
        {
            int totalWeight = 0;

            foreach (Candy candy in CandiesArray)
            {
                totalWeight += candy.weight;
            }
            return totalWeight;
        }

        public static Candy MaximalWeight(CandiesCollection Candies)
        {
            return (from Candy candy in Candies
                   orderby candy.weight descending
                   select candy).First();
        }

        public static Candy MinimalWeight(CandiesCollection Candies)
        {
            return (from Candy candy in Candies
                    orderby candy.weight 
                    select candy).First();
        }

        public static IEnumerable WeightFilter(CandiesCollection Candies, int weight)
        {
            return  from Candy candy in Candies
                    where candy.weight > weight
                    orderby candy.weight descending
                    select candy;
        }

        public static IEnumerable ColourFilter(CandiesCollection Candies, Sweets_Colour colour)
        {
            return from Candy candy in Candies
                   where candy.colour == colour
                   select candy;
        }

        public static IEnumerable TasteFilter(CandiesCollection Candies, Sweets_Taste taste)
        {
            return from Candy candy in Candies
                   where candy.taste == taste
                   select candy;
        }

        public static void OutputOnDisplay(CandiesCollection Candies)
        {
            foreach (Candy candy in Candies) { Console.WriteLine(candy); }          
        }
        
    }
}

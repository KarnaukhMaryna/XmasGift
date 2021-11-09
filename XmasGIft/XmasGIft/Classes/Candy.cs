using System;
using XmasGIft.Enum;

namespace XmasGIft.Classes
{
    class Candy
    {
        internal Sweets_Taste taste;
        internal Sweets_Colour colour;
        internal int weight;

        public Candy()
        {
            Random rand = new Random();
            taste = (Sweets_Taste)rand.Next(0, 5);
            colour = DefineColour(taste);
        }

        public Sweets_Colour DefineColour(Sweets_Taste taste)
        {
            switch (taste)
            {
                case Sweets_Taste.Orange:
                    return Sweets_Colour.Orange;
                    break;
                case Sweets_Taste.Apple:
                    return Sweets_Colour.Green;
                    break;
                case Sweets_Taste.Banana:
                    return Sweets_Colour.Yellow;
                    break;
                default:
                    return Sweets_Colour.Red;
                    break;
            }
        }

    }
}

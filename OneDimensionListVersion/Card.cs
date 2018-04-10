using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionListVersion
{
    public class Card
    {
        public enum Type { Spades, Hearts, Diamonds, Clubs };

        public Type type;

        public int number;

        public Card(Type type, int number)
        {
            this.type = type;
            this.number = number;
        }
    }
}

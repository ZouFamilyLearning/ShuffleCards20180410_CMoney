using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionListVersion
{
    public class Cards
    {
        public List<Card> cards = new List<Card>();

        public void newCards()
        {
            cards.Clear();

            for(int i = 0; i < 52; i++)
            {
                Card.Type type = (Card.Type)(i / 13);
                int number = i % 13;

                Card card = new Card(type, number);
                cards.Add(card);
            }
        }
    }
}

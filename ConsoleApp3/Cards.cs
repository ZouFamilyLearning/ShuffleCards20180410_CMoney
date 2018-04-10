using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Cards
    {
        public string[] cardsForm;
        public string[] cardsNumber;
        public int[,] cardArray;
        public int counter = 52;


        public void newCards(string[] cardsForm, string[] cardsNumber, int[,] cardArray, int counter)
        {
            this.cardsForm = cardsForm;
            this.cardsNumber = cardsNumber;
            this.cardArray = cardArray;
            this.counter = counter;
        }
    }
    
}

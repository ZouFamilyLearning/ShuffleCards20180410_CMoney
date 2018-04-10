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
        public int counter;


        public void newCards(string[] cardsForm, string[] cardsNumber, int[,] cardArray, int counter)
        {
            this.cardsForm = cardsForm;
            this.cardsNumber = cardsNumber;
            this.cardArray = cardArray;
            this.counter = counter;
        }
    }
    class ShuffleCards : Cards
    {
        Random RamCardi = new Random();
        Random RamCardj = new Random();

        public int remainCards()
        {
            int count = 0;
            Console.Write("剩下的牌有: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (cardArray[i, j] == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine();
            }
            return count;
        }

        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (cardArray[i, j] == 0)
                    {
                        tmp = String.Format($"ID:{cardsForm[i]}, NAME:{cardsNumber[j]}");
                    }
                }
                Console.WriteLine();
            }
            return tmp;
        }

        public void getCard(bool tmp)
        {
            bool hehe = true;
            do
            {
                int x = RamCardi.Next(0, 4);
                int y = RamCardj.Next(0, 13);
                if (tmp)
                {
                    if (cardArray[x, y] == 0)
                    {
                        Console.WriteLine($"你拿到的卡牌是: {cardsForm[x] + "," + cardsNumber[y]}");
                        cardArray[x, y] = 1;
                        counter--;
                        hehe = false;
                    }
                }
                else
                {
                    Console.WriteLine("=== 牌數不夠，故發新牌 ===");
                    cardArray = new int[4, 13];
                    counter = 52;
                    //newCards();
                }

            } while (hehe == true);
        }
    }
}

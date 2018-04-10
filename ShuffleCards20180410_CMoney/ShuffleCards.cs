using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleCards20180410_CMoney
{
    class Cards
    {
        public int[,] cards = new int[4, 13];
        public string[] cardsForm = new string[4] { "黑桃", "紅心", "方塊", "梅花" };
        public string[] cardsNumber = new string[13] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "J", "Q", "K" };
        public int counter = 52;
        public Random RamCardi = new Random();
        public Random RamCardj = new Random();


    }

    class ShuffleCards : Cards
    {
        public int remainCards()
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (cards[i, j] == 0)
                    {
                        Console.Write(cardsForm[i] + "," + cardsNumber[j] + "\t");
                        count++;
                    }
                }
                Console.WriteLine();
            }
            Console.Write("剩下的牌有: ");

            return count;
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
                    if (cards[x, y] == 0)
                    {
                        Console.WriteLine($"你拿到的卡牌是: {cardsForm[x] + "," + cardsNumber[y]}");
                        cards[x, y] = 1;
                        counter--;
                        hehe = false;
                    }
                }
                else
                {
                    Console.WriteLine("=== 牌數不夠，故發新牌 ===");
                    cards = new int[4, 13];
                    counter = 52;
                    //newCards();
                }

            } while (hehe == true);
        }

        public override string ToString()
        {
            return String.Format("{0},{1}\t", this.cardsForm, this.cardsNumber);
        }
    }
}

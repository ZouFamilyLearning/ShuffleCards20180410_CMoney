using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleCards20180410_CMoney
{
    class ShuffleCards : Cards
    {
        public List<List<int>> remainCardsDatas = new List<List<int>>();

        public int remainCards()
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (cards[i, j] == 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write("剩下的牌有: ");

            return count;
        }

        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (cards[i, j] == 0)
                    {
                        tmp += String.Format($"{cardsForm[i]},{cardsNumber[j]}\t");
                    }
                }
                tmp += "\n";
            }
            return tmp;
        }

        public void getCard()
        {
            remainCardsDatas.Clear();
            bool IsCardNotEmpty = counter != 0 ? true : false;

            if (!IsCardNotEmpty)
            {
                Console.WriteLine("=== 牌數不夠，故發新牌 ===");
                Console.WriteLine();
                newCards();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (cards[i, j] == 0)
                    {
                        List<int> smallList = new List<int>();
                        smallList.Add(i);
                        smallList.Add(j);
                        // --------------------------------------
                        remainCardsDatas.Add(smallList);
                    }
                }
            }
            List<int> getCardList = remainCardsDatas[RamCard.Next(0, remainCardsDatas.Count)];
            int form = getCardList[0];
            int number = getCardList[1];
            Console.WriteLine($"你拿到的卡牌是: {cardsForm[form] + "," + cardsNumber[number]}");
            Console.WriteLine();
            cards[form, number] = 1;
            counter--;
        }
    }
}

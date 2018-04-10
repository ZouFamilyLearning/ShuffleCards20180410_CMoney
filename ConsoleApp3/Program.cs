using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool haha = true;
            int input;
            int[,] cardArray = new int[4, 13];
            string[] cardsForm = new string[4] { "黑桃", "紅心", "方塊", "梅花" };
            string[] cardsNumber = new string[13] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "J", "Q", "K" };
            int counter = 52;
            do
            {
                Cards cards = new Cards();
                ShuffleCards shufflecards = new ShuffleCards();
                cards.newCards(cardsForm, cardsNumber, cardArray, counter);

                //int i = x.Next(0, 4);
                //int j = y.Next(0, 13);

                do
                {
                    Console.Write("Options: 1)remain cards, 2)get card, 3)發四張牌, -1)Quit: ");
                    input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:// 發剩下的牌(有花色和數字)
                            Console.Clear();
                            Console.WriteLine($"{shufflecards.remainCards()}張");
                            Console.WriteLine(shufflecards.ToString());
                            break;
                        case 2:// 隨機給使用者的牌(有花色和數字)
                            Console.Clear();
                            bool tmp1 = counter != 0 ? true : false;

                            shufflecards.getCard(tmp1);
                            break;
                        case 3:
                            Console.Clear();
                            bool tmp4 = counter > 4 ? true : false;
                            for (int i = 0; i < 4; i++)
                            { shufflecards.getCard(tmp4); }
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("--------------------------------------------------------");
                } while (input != -1);
                if (input == -1)
                {
                    Console.WriteLine("程式結束");
                    haha = false;
                    break;
                }
            } while (haha == true);
            Console.ReadKey();
        }
    }
}

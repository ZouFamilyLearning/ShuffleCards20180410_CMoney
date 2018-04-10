using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleCards20180410_CMoney
{
    class Program
    {

        static void Main(string[] args)
        {
            bool haha = true;
            int input;
            do
            {
                int counter = 52;
                Cards cardsNew = new Cards();
                ShuffleCards cardNum = new ShuffleCards();
                //cardsNew.newCards();
                do
                {
                    Console.Write("Options: 1)remain cards, 2)get card, 3)發四張牌, -1)Quit: ");
                    input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:// 發剩下的牌(有花色和數字)
                            Console.Clear();
                            Console.WriteLine($"{cardNum.remainCards()}張");
                            // Console.WriteLine(cardNum.ToString());
                            break;
                        case 2:// 隨機給使用者的牌(有花色和數字)
                            Console.Clear();
                            bool tmp1 = counter != 0 ? true : false;

                            cardNum.getCard(tmp1);
                            break;
                        case 3:
                            Console.Clear();
                            bool tmp4 = counter > 4 ? true : false;
                            for (int i = 0; i < 4; i++)
                            { cardNum.getCard(tmp4); }
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("--------------------------------------------------------");
                } while (input != -1);
                if (input == -1)
                {
                    haha = false;
                    break;
                }
            } while (haha == true);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool haha = true;
            int input;
            do
            {
                string[] cardsForm = new string[4] { "黑桃", "紅心", "方塊", "梅花" };
                string[] cardsNumber = new string[13] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "J", "Q", "K" };
                int[,] cards = new int[4, 13] {
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
                        { 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 },
                        { 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39 },
                        { 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 } };
                int counter = 52;
                do
                {

                    Console.Write("Options: 1)remain cards, 2)get card, 3)發四張牌, -1)Quit: ");
                    input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:// 發剩下的牌(有花色和數字)
                            Console.Clear();
                            Console.WriteLine("剩下的牌有: ");
                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 13; j++)
                                {
                                    if (cards[i, j] != 0)
                                    {
                                        Console.Write(cardsForm[i] + "," + cardsNumber[j] + "\t");
                                    }
                                }
                                Console.WriteLine();
                            }

                            break;
                        case 2:// 隨機給使用者的牌(有花色和數字)
                            Console.Clear();

                            Random RamCardi = new Random();
                            Random RamCardj = new Random();
                            bool hehe = true;
                            do
                            {
                                int x = RamCardi.Next(0, 4);
                                int y = RamCardj.Next(0, 13);
                                if (counter != 0)
                                {
                                    if (cards[x, y] != 0)
                                    {
                                        Console.WriteLine($"你拿到的卡牌是: {cardsForm[x] + "," + cardsNumber[y]}");
                                        cards[x, y] = 0;
                                        counter--;
                                        hehe = false;

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("=== 牌數不夠，故發新牌 ===");

                                    cards = new int[4, 13] {
                                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
                                        { 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 },
                                        { 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39 },
                                        { 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 } };
                                    counter = 52;
                                }

                            } while (hehe == true);
                            break;
                        case 3:
                            Console.Clear();

                            Random RamCardi4 = new Random();
                            Random RamCardj4 = new Random();
                            for (int i = 0; i < 4; i++)
                            {
                                bool hihi = true;
                                do
                                {
                                    int x = RamCardi4.Next(0, 4);
                                    int y = RamCardj4.Next(0, 13);
                                    if (counter > 4)
                                    {
                                        if (cards[x, y] != 0)
                                        {
                                            Console.WriteLine($"你拿到的卡牌是: {cardsForm[x] + "," + cardsNumber[y]}");
                                            cards[x, y] = 0;
                                            counter--;
                                            hihi = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("=== 牌數不夠，故發新牌 ===");
                                        cards = new int[4, 13] {
                                            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
                                            { 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 },
                                            { 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39 },
                                            { 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 } };
                                        counter = 52;
                                    }
                                } while (hihi == true);
                            }
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("--------------------------------------------------------");
                } while (input != -1);
            } while (haha == true);
            Console.ReadKey();
        }
    }
}

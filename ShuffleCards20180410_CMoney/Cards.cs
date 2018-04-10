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
        public Random RamCard = new Random();
        public void newCards()
        {
            cards = new int[4, 13];
            counter = 52;
        }
    }
}

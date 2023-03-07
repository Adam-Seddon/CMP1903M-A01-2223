using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class testing
    {
        public static void test()
        {
            /*Creates a Pack object
              Calls the shuffle method with all 3 shuffle types
              Calls both deal methods and displays what it returns
            */
            new Pack();
            Pack.shuffleCardPack(1);
            Pack.shuffleCardPack(2);
            Pack.shuffleCardPack(3);
            Console.WriteLine("Dealing 1 card");
            Console.WriteLine(Pack.deal());
            List<Card> Hand = Pack.dealCard(10);
            foreach (var card in Hand)
            {
                Console.WriteLine(card);
            }
            Console.Read();
        }
    }
}

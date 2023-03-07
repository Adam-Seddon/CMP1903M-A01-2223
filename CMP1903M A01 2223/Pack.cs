using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static List<Card> pack;

        public Pack()
        {
            //Initialises the card pack
            pack = new List<Card>();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    pack.Add(new Card(i, j));
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //if typeOfShuffle is 1 then it does the fisher-yates shuffle
            //if its 2 it does the riffle shuffle
            //and if its 3 it does no shuffle
            if (typeOfShuffle == 1)
            {
                //goes through the pack one at a time swapping each card with a random card
                Random rand = new Random();
                for (int i = 0; i < 52; i++)
                {
                    int j = rand.Next(i, 52);
                    Card tempcard = pack[i];
                    pack[i] = pack[j];
                    pack[j] = tempcard;
                }
            }
            if (typeOfShuffle == 2)
            {
                //splits the pack and goes through the 2nd half of the pack one at a time placing the cards inbetween each card in the first half
                for (int i = 0; i < 26; i++)
                {
                    pack.Add(pack[i]);
                    pack.Add(pack[i + 26]);
                }
                pack.RemoveRange(0, 52);
            }
            else
            {
                return true;
            }
                return true;
        }
        public static Card deal()
        {
            //Deals one card and puts it back at the back of the pack
            var card = pack[0];
            pack.Remove(card);
            pack.Add(card);
            return card;
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount' and then returns them to the back of the pack in order
            Console.WriteLine("Dealing "+amount+" cards");
            List<Card> hand = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                hand.Add(deal());
            }
            return hand;
        }
        
    }
}

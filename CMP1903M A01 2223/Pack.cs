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
            //Initialise the card pack here
            pack = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                                    .Select(c => new Card()
                                    {
                                        Suit = s,
                                        Value = c
        }
                                            )
                            )
                   .ToList();

                
        }


        /*0
        public static bool shuffleCardPack(int typeOfShuffle)
        {
           //Shuffles the pack based on the type of shuffle

        }*/
        public static Card deal()
        {
            //Deals one
            var card = pack.FirstOrDefault();
            pack.Remove(card);

            return card;
        }
        /*public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }*/
        
    }
}

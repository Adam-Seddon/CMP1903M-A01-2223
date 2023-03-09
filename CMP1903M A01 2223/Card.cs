using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        string[] values = {"Ace","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King"};
        string[] suits = {"Clubs", "Diamonds", "Hearts", "Spades"};
        public int Value { get; set; }
        public int Suit { get; set; }
        public Card(int i, int j)
        {
            this.Suit = i;
            this.Value = j;
        }
        public override string ToString()
        {
            //makes it easier to view cards as strings
            return $"The {values[Value-1]} of {suits[Suit-1]}";
        }
    }
}

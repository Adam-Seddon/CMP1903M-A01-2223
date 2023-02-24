using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            new Pack();
            Console.WriteLine("hi");
            Console.WriteLine("{0} a  {1}",Pack.deal().Suit,Pack.deal().Value);
            Console.Read();
        }
    }
}

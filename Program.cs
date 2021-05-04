using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paintings
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintings = 52;
            int paintingsInArow;  
            int paintingsAreNotInArow;
            paintingsInArow = paintings / 3;
            paintingsAreNotInArow = paintings % 3;
            Console.Write("Полностью заполненных рядов " + (paintingsInArow) + " и картин сверх меры " + (paintingsAreNotInArow) + ".");
            Console.ReadLine();
        }
    }
}

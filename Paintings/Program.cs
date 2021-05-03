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
            int picturesinarow;  //заполненные ряды кортин
            int paintingsb; //картин вне ряда
            picturesinarow = paintings / 3;
            paintingsb = paintings % 3;
            Console.Write("Полностью заполненных рядов " + (picturesinarow) + " и картин сверх меры " + (paintingsb) + ".");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int WaitingTime = 10;
            int OldLady;
            int hours;
            int minutes;

            Console.Write("Сколько в очереди старушек?:");
            OldLady = Convert.ToInt32(Console.ReadLine());
            hours = (OldLady * WaitingTime) / 60;
            minutes = (OldLady * WaitingTime) % 60;
            Console.Write("Вам стоять в очереди " + (hours) + " часов и " + (minutes) + " минут");
            Console.ReadLine();
        }
    }
}

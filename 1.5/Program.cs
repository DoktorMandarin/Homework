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
            int waitingTime = 10;
            int oldLady;
            int waitingHours;
            int waitingMinutes;

            Console.Write("Сколько в очереди старушек?:");
            oldLady = Convert.ToInt32(Console.ReadLine());
            waitingHours = (oldLady * waitingTime) / 60;
            waitingMinutes = (oldLady * waitingTime) % 60;
            Console.Write("Вам стоять в очереди " + (waitingHours) + " часов и " + (waitingMinutes) + " минут");
            Console.ReadLine();
        }
    }
}

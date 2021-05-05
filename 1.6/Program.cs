using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    class Program
    {
        static void Main(string[] args)
        {
            string youName;
            string youLiveSity;
            int youschool;
            int youAge;

            Console.Write("Как вас зовут?");
            youName = Console.ReadLine();
            Console.Write("Сколько вам лет?");
            youAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("В каком городе вы живете?");
            youLiveSity = Console.ReadLine();
            Console.Write("Какую школу вы закончили?");
            youschool = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут " + (youName) + ". Вам "  + (youAge) + " лет. Вы живете в " + (youLiveSity) + ". Вы закончили школу №" + (youschool) + "." );
            

        }
    }
}

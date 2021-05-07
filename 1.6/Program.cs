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
            string name;
            string yourLiveSity;
            int yourSchool;
            int yourAge;

            Console.Write("Как вас зовут?");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет?");
            yourAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("В каком городе вы живете?");
            yourLiveSity = Console.ReadLine();
            Console.Write("Какую школу вы закончили?");
            yourSchool = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут " + (name) + ". Вам " + (yourAge) + " лет. Вы живете в " + (yourLiveSity) + ". Вы закончили школу №" + (yourSchool) + ".");
            

        }
    }
}

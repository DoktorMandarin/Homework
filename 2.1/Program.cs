using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts;
            Console.Write("Сколько раз вы хотите увидеть слово Привет!!! ?");
            attempts = Convert.ToInt32(Console.ReadLine());

            while (attempts -- > 0)
            {
                Console.WriteLine("Привет!!!");
                
            }
            Console.ReadLine();

        }
        
    }
    
}


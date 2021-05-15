using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitWrod = "";

            while (exitWrod.ToLower() != "exit")
           
            {

                Console.WriteLine("Введите пароль для выхода:");
                exitWrod = Console.ReadLine();
           
            }
        }
    }
}
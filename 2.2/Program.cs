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
            string exitWrod = "123";
            int userInput;

            Console.Write("Введите слово для выхода:");
            userInput = Convert.ToInt32(Console.ReadLine());

            while (true)
                {
                   
                    if (Convert.ToInt32(exitWrod) == userInput)
                    {
                        Console.Write("Прощайте");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                      Console.WriteLine("Попробуйте еще");
                      Console.ReadKey();
                    }
                
                }
           
            
                    
             

                       
            
               
        }
    }
}

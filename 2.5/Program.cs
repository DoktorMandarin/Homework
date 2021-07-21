using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequence = 0;

            for (int i = 0; i < 14; i ++)
            {
                sequence += 7; 
                Console.WriteLine(sequence);
            }
        }
    }
}

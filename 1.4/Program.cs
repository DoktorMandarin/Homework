using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int golds;
            int goldLeft;
            int crystalForGold = 3;
            int crystals;
            Console.Write("Сколько у вас золота?: ");
            golds = Convert.ToInt32(Console.ReadLine());
            Console.Write("У меня кристалы по цене " + (crystalForGold) + " золота за штуку. Сколько хотите купить?");
            crystals = Convert.ToInt32(Console.ReadLine());
            goldLeft = (golds - (crystals* crystalForGold));
            Console.Write("У вас " + (crystals) + " кристалов и " + (goldLeft) +" золота." );
            Console.ReadLine();
        }
    }
}

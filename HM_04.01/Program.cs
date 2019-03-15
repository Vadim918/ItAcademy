using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_04.1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для премещения используйте 'w','s','a','d'");
            var insertValue = Console.Read();
            if (insertValue == 'w')
                Console.WriteLine("Движение прямо");
            else if (insertValue == 's')
                Console.WriteLine("Движение назад");
            else if (insertValue == 'a')
                Console.WriteLine("Движение влево");
            else if (insertValue == 'd')
                Console.WriteLine("Движение вправо");
            else
            {
                Console.WriteLine("Движение не требуется");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    class PassControl
    {
        public void Pass(CheckIn checkIn)
        {
            string usname = checkIn.Usname;
            string s = CheckIn.read;
            Console.WriteLine(s);
            Console.ReadKey();
            Console.WriteLine($"{usname},здравствуйте у вас есть виза ? \n Нажмите Y или N");            
            string selc = Console.ReadLine();
            while (selc != "Y" && selc != "N" && selc != "y" && selc != "n")
            {
                Console.WriteLine("Вы нажали неизвестый символ  \n Введите Y или N");
                selc = Console.ReadLine();
            }
            switch (selc)
            {
                case "Y":
                    Console.WriteLine("Проходите дальше на посадку,хорошего полёта");
                    break;
                case "N":
                    Console.WriteLine("Вы не можете полететь без визы");
                    break;
            }
        }
    }
}

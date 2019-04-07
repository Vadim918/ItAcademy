using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    public class Security : CheckIn
    {
        public void Sec(CheckIn checkIn)
        {
            string usname = checkIn.Usname;
            string str = CheckIn.read;
            Console.WriteLine(str);
            Console.ReadKey();
            Console.WriteLine($"{usname},здравствуйте,у вас есть запрещённые предметы? \n Нажмите Y или N");
            string sel = Console.ReadLine();
            while (sel != "Y" && sel != "N" && sel != "y" && sel != "n")
            {
                Console.WriteLine("Вы нажали неизвестый символ  \n Введите Y или N");
                sel = Console.ReadLine();
            }
            switch (sel)
            {
                case "Y":
                    Console.WriteLine("Здайте запрещённые предметы \n И проходите дальше для проверки пасспорта и визы");
                    break;
                case "N":
                    Console.WriteLine("Хорошо проходите для проверки пасспорта и визы");
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    public class CheckIn 
    {
        public const string read = "Для продолжения нажмите любую клавишу";       
        public  string Usname { get; set; }
        public void Reg(CheckIn check)
        {
            string usname = check.Usname; 
            Console.WriteLine($" {usname},вы проходили онлайн регистрацию?  \n Введите Y или N");
            string ans = Console.ReadLine();
            while (ans != "Y" && ans != "N")
            {
                Console.WriteLine("Вы нажали неизвестый символ  \n Введите Y или N");
                ans = Console.ReadLine();
            }
            switch (ans)
            {
                case "Y":
                    Console.WriteLine($"{usname},покажите ваш билет и пасспорт \n Здайте ваш багаж");
                    break;
                case "N":
                    Console.WriteLine("Покажите ваш паспорт вам оформят билет \n Здайте ваш багаж ");
                    break;                
            }
            string s = CheckIn.read;
            Console.WriteLine( s );
            
            Console.ReadKey();
        }
        
    }
}

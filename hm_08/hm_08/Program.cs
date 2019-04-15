using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    class Programn 
    {    
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Здравствуйте,вас приветствует аэропорт Belavia \n Представтесь пожалуйста");
            string usname = Console.ReadLine();
            Console.WriteLine($"Проходите на регистрацию {usname}");
            CheckIn checkIn = new CheckIn();
            checkIn.Usname = usname;
            checkIn.Reg(checkIn);            
            Console.WriteLine("Проходите дальше для досмотра");
            Security security = new Security();
            security.Sec(checkIn);
            PassControl pass = new PassControl();
            pass.Pass(checkIn);
            
             Console.ReadKey();
        }
    }
}

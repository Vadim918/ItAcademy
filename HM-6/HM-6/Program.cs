using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение в однну строку,разделяя строки точкой с запятой");
            string  str = Console.ReadLine();
            str = str.Replace("а", "о");
            str = str.Replace("А", "О");
            string[] words = str.Split(new char[] { ';' });
            for (int i = 0; i <words.Length; i++)
            {
                Console.WriteLine($"words[{i}] = {words[i]} ");
            }
            Console.ReadKey();

        }
    }
}

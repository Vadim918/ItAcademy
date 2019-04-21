using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM10
{
   public class Square : IBase
    {
        public string name { get ; set; }
        public int side { get; set; }
        public object Ar()
        {
            Random random = new Random();
            side = random.Next(1, 10);
            int areaSqare = side * side;
            return areaSqare;
        }
    }
}

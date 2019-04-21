using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM10
{
   public class Triangle : IBase
    {
        public string name { get; set; }
        public int sideTriangleBasis { get; set; }
        public int side { get; set; }
        public object Ar()
        {
            Random random = new Random();
            side = random.Next(1, 10);
            sideTriangleBasis = random.Next(1, 10);
            double areaTriangle = sideTriangleBasis / 4 * (Math.Sqrt(4 * (side * side) - (sideTriangleBasis * sideTriangleBasis)));
            return areaTriangle;
        }
    }
      
        
    
}

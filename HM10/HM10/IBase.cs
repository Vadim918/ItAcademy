using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM10
{
    interface IBase
    {
        string name { get; set; }
        int side { get; set; }
        object Ar();
    }
}

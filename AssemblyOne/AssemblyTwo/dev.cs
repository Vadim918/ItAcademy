using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    class Dev : Employee
    {
        int numProt = Employee.numProtected;
        int numProtInter = Employee.numProtectedIntrnal;
    }
}

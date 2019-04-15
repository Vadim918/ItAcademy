using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Employee
    {
        public const int numPublic = 55;
        protected const int numProtected = numPublic;
        internal const int numInternal = numPublic;
        protected internal const int numProtectedIntrnal = numPublic;
        private const int numPrivate = numPublic;

        int numPriv = Employee.numPrivate;
    }
}

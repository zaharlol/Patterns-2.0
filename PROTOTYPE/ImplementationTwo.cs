using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTOTYPE
{
    internal class ImplementationTwo : IBaseClass
    {
        int a;

        public ImplementationTwo(int A)
        {
            A = a;
        }
        public IBaseClass Clone()
        {
            return new ImplementationTwo(2);
        }

        public void GetId()
        {
            Console.WriteLine("Содан объект с Id 2");
        }
    }
}


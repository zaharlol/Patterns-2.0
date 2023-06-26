using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTOTYPE
{
    internal class ImplementationOne : IBaseClass
    {
        int a;
        public ImplementationOne(int A) 
        {
            A = a;
        }
        public IBaseClass Clone()
        {
            return new ImplementationOne(1);
        }

        public void GetId()
        {
            Console.WriteLine("Содан объект с Id 1");
        }
    }
}

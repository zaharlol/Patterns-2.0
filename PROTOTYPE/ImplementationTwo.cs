using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTOTYPE
{
    internal class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int id) : base(id)
        {

        }
        public override BaseClass Clone()
        {
            return new ImplementationTwo(Id);
        }
    }
}


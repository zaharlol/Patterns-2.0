using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTOTYPE
{
    abstract class BaseClass
    {
        public int Id { get; }

        public BaseClass(int id)
        {
            Id = id;
        }

        public abstract BaseClass Clone();
        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {Id}");
        }
    }
}

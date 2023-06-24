using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_2._0
{
    class Product
    {
        private string _type;

        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Product(string type)
        {
            _type = type;
        }
        public string this[string key]
        {
            set
            {
                _parts[key] = value;
            }
        }
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид транспортного средства: {_type}");
            Console.WriteLine($" Рама : {_parts["frame"]}"); Console.WriteLine($" Двигатель : {_parts["engine"]}");
            Console.WriteLine($" Колеся: {_parts["wheels"]}");
            Console.WriteLine($" Двери : {_parts["doors"]}");
        }
    }
}

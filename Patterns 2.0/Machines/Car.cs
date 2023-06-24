using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_2._0.Machines
{
    internal class Car : Conveyor
    {
        public Car()
        {
            _product = new Product("Машина");
        }
        public override void BuildDoors()
        {
            _product["doors"] = "4";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "150 л.с.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама машины";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "4";
        }
    }
}

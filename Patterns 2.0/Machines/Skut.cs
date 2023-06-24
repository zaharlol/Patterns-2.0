using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_2._0.Machines
{
    internal class Skut : Conveyor
    {
        public Skut()
        {
            _product = new Product("Скутер");
        }
        public override void BuildDoors()
        {
            _product["doors"] = "0";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "30 л.с.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама скутера";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "2";
        }
    }
}

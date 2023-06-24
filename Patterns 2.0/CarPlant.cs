using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_2._0
{
    class CarPlant
    {
        public void Construct(Conveyor conveyor)
        {
            conveyor.BuildFrame();
            conveyor.BuildEngine();
            conveyor.BuildWheels();
            conveyor.BuildDoors();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class GateOpenAction : Commander
    {
        Gate gate { get; }
        public GateOpenAction(Gate _gate) 
        { 
            gate = _gate;
        }
        public override void Close()
        {
            gate.Close();
        }
        public override void Open()
        {
            gate.Open();
        }
    }
}

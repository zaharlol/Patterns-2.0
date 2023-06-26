using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Pult
    {
        Commander commander;
        public void SetAction(Commander _commander) 
        { 
        commander = _commander;
        }
        public void OpenButton() 
        { 
            commander.Open();
        }
        public void CloseButton() 
        { 
            commander.Close();
        }
    }
}

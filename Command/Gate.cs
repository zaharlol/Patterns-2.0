﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Gate
    { 
            public void Open()
            {
                Console.WriteLine("Открываем ворота");
            }

            public void Close()
            {
                Console.WriteLine("Закрываем ворота");
            }
        
    }
}

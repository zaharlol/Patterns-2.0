﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTOTYPE
{
    public interface IBaseClass
    {
        IBaseClass Clone();
        void GetId();
    }
}
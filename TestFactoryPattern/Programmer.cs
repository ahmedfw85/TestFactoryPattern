﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryPattern
{
    class Programmer : Position
    {
        public override string Title
        {
            get
            {
                return "Programmer";
            }
        }
    }
}

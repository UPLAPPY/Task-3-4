﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{ 
    public interface IPrinter
    {
        void PrintArray();
    }

    public interface IBaseArr: IPrinter
    {
        void Average();
        void Create(bool avto_input = false);
    }
}


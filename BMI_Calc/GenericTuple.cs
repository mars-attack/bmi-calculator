﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calc
{

    // Custom Generic class (struct)
    public struct GenericTuple<T1, T2, T3>
    {
        public readonly T1 Item1;
        public readonly T2 Item2;
        public readonly T3 Item3;

        public GenericTuple(T1 item1, T2 item2, T3 item3) { Item1 = item1; Item2 = item2; Item3 = item3; }

    }

    public struct GenericTuple<T1, T2>
    {
        public readonly T1 Item1;
        public readonly T2 Item2;

        public GenericTuple(T1 item1, T2 item2) { Item1 = item1; Item2 = item2; }

    }
}

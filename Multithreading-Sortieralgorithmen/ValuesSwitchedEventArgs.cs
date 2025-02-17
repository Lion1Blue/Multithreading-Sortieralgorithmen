﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading_Sortieralgorithmen
{
    class ValuesSwitchedEventArgs : EventArgs
    {
        public ValuesSwitchedEventArgs(int index1, int index2, double value1, double value2)
        {
            Index1 = index1;
            Index2 = index2;
            Value1 = value1;
            Value2 = value2;
        }

        public int Index1 { get; private set; }
        public int Index2 { get; private set; }

        public double Value1 { get; private set; }
        public double Value2 { get; private set; }
    }
}

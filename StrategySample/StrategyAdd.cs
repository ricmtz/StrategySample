using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample
{
    class StrategyAdd<T>: IStrategy<T>
    {
        public T Execute(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;
        }
    }
}

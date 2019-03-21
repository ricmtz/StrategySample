using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample
{
    class Contex<T>
    {
        private IStrategy<T> strategy;
        
        public void SetEstrategy(IStrategy<T> strategy) {
            this.strategy = strategy;
        }

        public T ExecuteStrategy(T a, T b) {
            return this.strategy.Execute(a, b);
        }
    }
}

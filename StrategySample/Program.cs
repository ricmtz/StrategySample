using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Contex<double> contex = new Contex<double>();
            String action;
            double num1 = 12.2, num2 = 24.4;
            action = Console.ReadLine();
            action = action.ToLower();
            if(action == "add") {
                contex.SetEstrategy(new StrategyAdd<double>());
            } else if (action == "sub") {
                contex.SetEstrategy(new StrategySubtract<double>());
            } else if (action == "mul") {
                contex.SetEstrategy(new StrategyMultiply<double>());
            }
            var result = contex.ExecuteStrategy(num1, num2);
            Console.WriteLine("Result: {0}, type: {1}", result, result.GetType());
            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class SumAll
    {
        public T Sum<T>(T obj1, T obj2)
        {
            dynamic num1 = obj1;
            dynamic num2 = obj2;

            T result = num1 + num2;

            Console.WriteLine($"La suma de {num1} y {num2} es igual a: {result}");

            return result;
        }
    }
}

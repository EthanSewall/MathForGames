using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QuadraticFunction(6).ToString());
            Console.ReadKey();
        }

        static float QuadraticFunction(float x)
        {
            x = (x * x) + (x * 2) + (-7);

            return x;
        }
    }
}

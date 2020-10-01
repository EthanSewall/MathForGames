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
            Console.WriteLine(QuadraticFormula(1,-1,-1)[0]);
            Console.WriteLine(QuadraticFormula(1,-1,-1)[1]);
            Console.ReadKey();
        }

        static float QuadraticFunction(float x)
        {
            x = (x * x) + (x * 2) + (-7);

            return x;
        }

        static float[] QuadraticFormula(float a, float b, float c)
        {
            float root1 = 0;
            float root2 = 0;
            if ((b*b) - ( 4f * a * c)> 0)
            {
                root1 = ((b * -1f) + ((float)(Math.Sqrt((double)((b * b) - (4f * a * c)))))) /(2 * a);
                root2 = ((b * -1f) - ((float)(Math.Sqrt((double)((b * b) - (4f * a * c)))))) /(2 * a);
                return new float[] { root1, root2 };
            }
            else
            {
                Console.WriteLine("No roots.");
                return null;
            }
        }
    }
}

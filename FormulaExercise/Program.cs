using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaExercise
{
    class Program
    {
        public struct Point2
        {
            public float x;
            public float y;
        }

        public struct Point3
        {
            public float x;
            public float y;
            public float z;
        }

        public struct Plane
        {
            public float a;
            public float b;
            public float c;
            public float d;
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static float QuadraticFunction(float x)
        {
            x = (x * x) + (x * 2) + (-7);

            return x;
        }

        static float[] QuadraticFormula(float a, float b, float c)
        {
            float root1;
            float root2;
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

        static float LinearBlend(float s, float e, float t)
        {
            return s + (t *(e-s));
        }

        static float PointDistance(Point2 a, Point2 b)
        {
            float c;
            c = (float)Math.Sqrt(((b.x - a.x)*(b.x-a.x)) + ((b.y-a.y)*(b.y-a.y)));
            return c;
        }

        static float TwoPointInnerProduct(Point3 a, Point3 b)
        {
            float h;
            h = (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
            return h;
        }

        static float PlaneDist(Point3 X, Plane P)
        {
            float h;
            h = ((P.a * X.x) + (P.b * X.y) + (P.c * X.z) + P.d) / (float)Math.Sqrt((P.a * P.a) + (P.b * P.b) + (P.c * P.c));
            return h;
        }
    }
}

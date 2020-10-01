using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometry_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static float DegToRad(float x)
        {
            return (x / 180) * (float)(Math.PI);
        }
        static float RadToDeg(float x)
        {
            return (x / (float)(Math.PI)) * 180;
        }

        static float[] SideSideSide(float sideA, float sideB, float hypotenuse)
        {

            if (hypotenuse > sideA && hypotenuse > sideB)
            {
                float angleA = sideA / hypotenuse;
                angleA = (float)(Math.Asin(angleA));
                float angleB = sideB / hypotenuse;
                angleB = (float)(Math.Asin(angleB));
                float angleC = (180f - angleA) - angleB;
                return new float[] { angleA, angleB, angleC};
            }
            else
            {
                Console.WriteLine("Invalid triangle, hypotenuse too short");
                return null;
            }
        }
    }
}

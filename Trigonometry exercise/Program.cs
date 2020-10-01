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
            return (x/180) * (float)(Math.PI);
        }
        static float RadToDeg(float x)
        {
            return (x / (float)(Math.PI)) * 180;
        }
    }
}

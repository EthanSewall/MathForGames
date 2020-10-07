using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertBinary(10));
            Console.ReadKey();
        }

        static string ConvertBinary(int toConvert)
        {
            string remainders = "";
            string result = "";

            while (toConvert > 1)
            {
                if(toConvert % 2 == 0)
                {
                    remainders += "0";
                    toConvert /= 2;                   
                }
                else if(toConvert % 2 == 1)
                {
                    remainders += "1";
                    toConvert++;
                    toConvert /= 2;
                    toConvert--;
                }
            }
            if(toConvert == 1)
            {
                remainders += "1";
            }

            for (int i = remainders.Length-1; i > -1; i--)
            {
                result += remainders[i];
            }

            return result;
        }
    }
}

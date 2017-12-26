using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MathConsole
{
    class Program
    {


        static void Main(string[] args)
        {
            bool carry = false;
            string numerator = "19754313234";
            string result = DivideBy2(numerator, out carry);
            Console.WriteLine("{0}, {1}", result, carry);
            test1();
        }

        private static string DivideBy2(string num, out bool carry)
        {
            string stringresult = "Error: Routine incomplete";

            //TODO zet hier je staartdeling routine

            if (((int)(num.Last()) % 2) == 0)
            {
                carry = true;
            }
            else
            {
                carry = false;
            }

            return stringresult;
        }

        /// <summary>
        /// Create a long number for encoding.
        /// </summary>
        private static void test1()
        {
            BigInteger num = BigInteger.Pow(173, 7);
            BigInteger big = BigInteger.Parse("53456748383765543");
            BigInteger longnumber = BigInteger.Pow(big, 673);
            Console.WriteLine(longnumber);
            Console.WriteLine("\nlengte {0} num - big = {1}\n", longnumber.ToString().Length, num - big);
        }
    }
}

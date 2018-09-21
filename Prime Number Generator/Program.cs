using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_340___CSharp_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //reset file
            File.WriteAllText("PrimeNumbers.txt", String.Empty);

            for (long i = 0; ; i++)
            {
                if (IsPrimeNumber(i))
                {
                    //print to file
                    using (StreamWriter w = File.AppendText("PrimeNumbers.txt"))
                    {
                        w.WriteLine(i);
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static bool IsPrimeNumber(long n)
        {
            var max = Convert.ToInt32(Math.Sqrt(n));

            //check if number is less than two or divisible by two
            if (n < 2 || n % 2 == 0)
            {
                return false;
            }
            //check if number is two
            else if (n == 2)
            {
                return true;
            }
            //loop through all odd numbers from 3 to the sqrt of n, if n is divisible by any numbers here it is not prime
            for (var i = 3; i <= max; i = i + 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

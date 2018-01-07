using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Only need to test for divisibility from numbers 11-20
            bool divisible = true;

            int smallestNumber = 0;

            for (int i = 1; i > 0; i++)
            {
                for (int j = 11; j <= 20; j++)
                {
                    if (i % j == 0)
                    {
                        divisible = true;
                    }
                    else if (i % j != 0)
                    {
                        divisible = false;
                        break;
                    }
                }

                if (divisible)
                {
                    smallestNumber = i;
                    break;
                }
            }

            Console.WriteLine("The smallest number divisible by all numbers 1 to 20 is: {0}", smallestNumber);
            Console.ReadLine();
        }
    }
}

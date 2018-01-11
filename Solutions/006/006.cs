using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _006
{
    public class Program
    {
        public static void Main(string[] args)
        {
                       
            int sumOfSquares = 0;

            int sum = 0;
            int squareOfSum= 0;

            int difference = 0;

            int max = 100;

            for (int i = 1; i <= max; i++)
            {
                 sum += i;
                 sumOfSquares += i*i;
            }

            squareOfSum = sum*sum;

            difference = squareOfSum - sumOfSquares;

            Console.WriteLine("The difference between the sum of the squares and the square of the sum is: {0}", difference);
        }
    }
}

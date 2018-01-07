using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 100;
            int finish = 999;

            long CurrentProduct = 0;
            long CurrentProductReversed = 0;

            string CurrentProductStr = "";
            string CurrentProductStrReversed = "";

            long LargestPalindrome = 0;

            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    CurrentProduct = i * j;
                    CurrentProductStr = CurrentProduct.ToString();

                    CurrentProductStrReversed = "";

                    for (int k = CurrentProductStr.Length - 1; k >= 0; k--)
                    {
                        CurrentProductStrReversed += CurrentProductStr[k];
                    }

                    CurrentProductReversed = int.Parse(CurrentProductStrReversed);

                    if (CurrentProductReversed == CurrentProduct)
                    {
                        Console.WriteLine("{0} is a palindrome.", CurrentProduct);

                        if (CurrentProduct > LargestPalindrome)
                        {
                            LargestPalindrome = CurrentProduct;
                        }
                    }
                }
            }

            Console.WriteLine("The largest palindrome is: {0}", LargestPalindrome);
        }
    }
}

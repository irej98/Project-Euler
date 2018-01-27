#include <iostream>
#include <math.h>
using namespace std;

int main()
{
  int i = 0;
  bool prime = true;
  long ithPrime = 0;

  for(i = 2; ithPrime < 10001; i++)
  {

    for(int n = 2; n <= sqrt(i); n++)
    {
      /*
      Testing if current value of i is prime, by testing
      if numbers less than sqrt(i) are factors of i. Only need to test
      up to square root because after it is repetition.
      */
      if(i%n!=0)
      {
        prime = true;
      }
      else
      {
        prime = false;
        break;
      }

    }
    if(prime)
    {
      //Lists all prime numbers followed by the ith Prime it is on the line below.
      cout << i << endl;
      ithPrime += 1;
      cout << ithPrime << endl;
    }

  }

  //cout << "Largest prime factor is: " << largestPrimeFactor << endl;


}

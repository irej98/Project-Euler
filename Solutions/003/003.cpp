#include <iostream>
#include <math.h>
using namespace std;

int main()
{
  int i;
  bool prime = true;
  long largestPrimeFactor = 0;

  //Largest prime factor will be below square root of number

  for(i=1; i<sqrt(600851475143); i++)
  {

    for(int n=2; n<=sqrt(i); n++)
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
      //Lists all prime numbers
      //cout << i << endl;

      //Tests if current prime number is factor of 600851475143
      if((600851475143 % i)==0)
      {
        largestPrimeFactor = i;
        cout << i << " is a prime factor of 600851475143." << endl;
      }
    }

  }

  cout << "Largest prime factor is: " << largestPrimeFactor << endl;

}

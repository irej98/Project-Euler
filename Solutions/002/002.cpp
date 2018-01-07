#include <iostream>

int main()
{
  int num1 = 1;
  int num2 = 2;
  int numCurrent = 2;
  int total = 0;

  std::cout << num1 << std::endl;
  std::cout << num2 << std::endl;

  while(numCurrent <= 4000000)
  {
    if(numCurrent%2==0)
    {
      total += numCurrent;
    };

    std::cout << numCurrent << std::endl;
    numCurrent = num1+num2;
    num1 = num2;
    num2 = numCurrent;


  };

  std::cout << "The total of even Fibonacci numbers is: " << total << std::endl;

};

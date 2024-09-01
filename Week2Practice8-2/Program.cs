using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practice8_2
{
    class Program
    {
        static bool IsPrime(int number) // Method to check if a number is prime
        {
            if (number < 2) // Check if number is less than 2, since 0 and 1 are not prime
            {
                return false; // Return false if divisor is found
            }
            for (int i = 2; i <= Math.Sqrt(number); i++) // Loop through numbers from 2 to the square root of the number
            {
                if (number % i == 0) // If number is divisable by any i, it is not prime
                {
                    return false; // Return false if divisor is found
                }
            }
            return true; // If no divisors are found, the number is prime
        }
        static void Main()
        {
            int number = 29; // Declare a number to check if it's prime
            bool isPrime = IsPrime(number); // Call the IsPrime method and store the result
            if (isPrime) // Print whether the number is prime
            {
                Console.WriteLine(number + " is a prime number."); // Printed message for prime number
            }
            else // Print whether the number is prime
            {
                Console.WriteLine(number + " is not a prime number."); // Printed message for number that isn't prime
            }
            Console.ReadLine(); // Wait before closing
        }
    }
}

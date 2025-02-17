using System; // Importing the System namespace

namespace System.Numbers // Defining a namespace called System.Numbers
{
    public class PrimeService // Declaring a public class named PrimeService
    {
        // This method checks if a given number (candidate) is a prime number
        public bool IsPrime(int candidate)
        {
            // If the candidate number is less than 2, it is not a prime number
            if (candidate < 2)
            {
                return false; // Return false because numbers less than 2 are not prime
            }

            // Loop from 2 to the square root of the candidate number
            for (int divisor = 2; divisor <= Math.Sqrt(candidate); ++divisor)
            {
                // If the candidate number is divisible by any number in this range, it is not a prime number
                if (candidate % divisor == 0)
                {
                    return false; // Return false because the candidate is divisible by divisor
                }
            }
            // If no divisors were found, the candidate is a prime number
            return true; // Return true because the candidate is a prime number
        }
    }
}

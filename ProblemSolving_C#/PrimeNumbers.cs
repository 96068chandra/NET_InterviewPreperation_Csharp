using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_C_
{
    public class PrimeNumbers
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=int.Parse(Console.ReadLine());
            bool isPrime = true;
            for(int i=2;i<num/2;i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Number is Prime");

            }
            else
            {
                Console.WriteLine("Given number is not a prime number");
            }

            Console.WriteLine("Print Prime number between the given numbers");
            Console.WriteLine("Enter first number");
            int first=int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Enter last number");
            int End=int.Parse(Console.ReadLine()) ;

            Console.WriteLine($"Prime numbers between the range {first} and {End}");
            for(int i=first;i<End;i++)
            {
                int counter = 0;
                for(int j=2;j<i/2;j++)
                {
                    if (i%j==0)
                    {
                        counter++;
                        break;
                    }
                }
                if(counter==0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();

        }
    }
}

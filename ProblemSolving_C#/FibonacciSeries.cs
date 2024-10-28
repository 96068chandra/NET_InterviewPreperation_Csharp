using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_C_
{
    public class FibonacciSeries
    {
        static void Main2(string[] args)
        {
            //using iterative approach

            int First = 0, Second = 1, next, numberofElements;

            Console.Write("Enter number of elements to print:");
            numberofElements=int.Parse(Console.ReadLine());
            FibonocciSeries(0, 1, 1, numberofElements);
            if (numberofElements < 2)
            {
                Console.Write("Please enter a number greater than 2");
            }

            else
            {
                Console.Write(First + "," + Second + ",");
                for(int i=2;i<numberofElements;i++) 
                {
                    next = First + Second;
                    Console.Write(next + ",");
                    First = Second;
                    Second = next;
                }
            }

            //using recursion
           

            Console.ReadKey ();

        }

        public static void FibonocciSeries(int first,int second,int counter,int numberofelements)
        {
            Console.Write(first + ",");
            if(counter > numberofelements) 
            { 
                FibonocciSeries(second,first+second,counter+1,numberofelements);
                
            }
        }

        
        
    }
}

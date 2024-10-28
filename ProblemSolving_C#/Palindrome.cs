using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_C_
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Program");
            Console.WriteLine("Enter a the input number");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the word:");
            string name=Console.ReadLine();
            string rev=string.Empty;
            int reminder, sum = 0;
            int temp=num;
            while (num > 0)
            {
                //Get the reminder by dividing the number with 10
                //1234%10=4
                //4
                //123
                //3
                //43
                //12
                //2
                //432
                //1
                //4321
                reminder = num % 10;
                //multiply sum with 10 and then add the reminder
                sum =(sum*10)+reminder;
                //Get quotient by dividing the number with 10 

                num=num/10;



            }
            for(int i=name.Length-1;i>=0;i--)
            {
                rev += name[i];
            }
            if(temp==sum&&name==rev)
            {
                Console.WriteLine($"Number {temp} is Palindrome");
                Console.WriteLine($"Given word{name} is palindrome");

            }
            else if(temp==sum&&name != rev)
            {
                Console.WriteLine($"Number {temp} is Palindrome");
                Console.WriteLine($"Given word {name} is not palindrome");

            }
            else if (temp != sum && name == rev)
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
                Console.WriteLine($"Given word {name} is palindrome");

            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
                Console.WriteLine($"Given word{name} is not palindrome");

            }
            
            Console.ReadKey();


        }
    }
}

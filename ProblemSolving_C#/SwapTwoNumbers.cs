//Swapping 2 numbers using 3rd variable

public class SwapTwoNumbers
{
    static void Main1(string[] args)
    {
        Console.WriteLine("Swapping 2 numbers using 3rd variable");
        Console.WriteLine("----------------------------------------------");
        int num1 = 10, num2 = 20, temp = 0;
        Console.WriteLine($"Numbers before swapping \n num1:{num1}\nnum2:{num2}");
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"Numbers After swapping \n num1:{num1}\nnum2:{num2}");

        Console.WriteLine("Swapping 2 numbers without using 3rd variable using *,/");
        Console.WriteLine("----------------------------------------------");

        num1 = num1 * num2;
        num2=num1/num2;
        num1=num1/num2;

        Console.WriteLine($"Numbers after swapping \n num1:{num1}\nnum2:{num2}");
        Console.WriteLine("Swapping 2 numbers without using 3rd variable using +,-");
        num1 =num1+num2;
        num2 = num1 - num2;
        num1=num1-num2;
        Console.WriteLine($"Numbers after swapping \n num1:{num1}\nnum2:{num2}");

        Console.WriteLine("Swap 2 string without using 3rd variable");
        string var1 = "Chandra", var2 = "Sanjana";
        Console.WriteLine($"Before swapping \n var1={var1} \n var2={var2} ");
        var1=var1+var2;
        var2 = var1.Substring(0, var1.Length - var2.Length);
        var1 = var1.Substring(var2.Length);
        Console.WriteLine($"After swapping \n var1={var1} \n var2={var2} ");




    }
}

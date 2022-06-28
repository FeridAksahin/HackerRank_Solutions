using System;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursive instance = new Recursive();
            Console.WriteLine(instance.factorial(5));
            instance.FactorialWithFor(5);
        }
    }
}

class Recursive
{
    public int factorial(int num) //with Recursive method
    {
        if (num == 1)
        {
            return num;
        }
        return factorial(num - 1) * num;
    }

    public void FactorialWithFor(int n)
    {
        int factorial = 1;
        for(int i = 2; i<=n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }


}
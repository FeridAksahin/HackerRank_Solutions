using System;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions get = new Questions();
            //    get.FirstQuestion();
            //    get.SecondQuestion();
            get.ThirdQuestion();
        }
    }
}

class Questions
{
    public void FirstQuestion()
    {
        ArrayList prime = new ArrayList();
        ArrayList nonPrime = new ArrayList();
        double[] collectNum = new double[20];
        double input = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Enter {0}. num = ", i + 1);
            input = Convert.ToDouble(Console.ReadLine());
            if (input >= 1)
            {
                collectNum[i] = input;
            }

        }
        double sum_of_prime = 0;
        double sum_of_nonPrime = 0;

        for (int i = 0; i < 20; i++)
        {
            int count = 0;
            for (int j = 2; j < collectNum[i]; j++)
            {
                if (collectNum[i] % j == 0 || collectNum[i] == 2)
                {
                    count++;
                    break;
                }
            }

            if (count == 1 || collectNum[i] == 1)
            {
                nonPrime.Add(collectNum[i]);
                sum_of_nonPrime += collectNum[i];
            }
            else
            {
                prime.Add(collectNum[i]);
                sum_of_prime += collectNum[i];
            }
        }
        Console.WriteLine("*****");
        Console.WriteLine(sum_of_nonPrime);
        Console.WriteLine(sum_of_prime);
        Console.WriteLine("*****");
        prime.Sort();
        nonPrime.Sort();
        foreach (var i in prime)
        {
            Console.WriteLine("Prime = " + i);
        }
        Console.WriteLine("*****");
        foreach (var i in nonPrime)
        {
            Console.WriteLine("Non-prime = " + i);
        }
        double primeLen = prime.Count;
        double nonPrimeLen = nonPrime.Count;
        double primeAverage = sum_of_prime / primeLen;
        double nonPrimeAverage = sum_of_nonPrime / nonPrimeLen;

        Console.WriteLine("*****");
        Console.WriteLine("Length of array with prime numbers: " + primeLen);
        Console.WriteLine("Average of array containing prime numbers: " + primeAverage);
        Console.WriteLine("Length of array with non-prime numbers: " + nonPrimeLen);
        Console.WriteLine("Average of array containing non-prime numbers: " + nonPrimeAverage);
    }

    public void SecondQuestion()
    {
        ArrayList arrayList = new ArrayList();
        ArrayList maxArray = new ArrayList();
        ArrayList minArray = new ArrayList();

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Enter {0}. number: ", i + 1);
            arrayList.Add(Convert.ToDouble(Console.ReadLine()));
        }

        for (int i = 0; i < 3; i++)
        {
            double max = int.MinValue;
            double min = int.MaxValue;
            foreach (double t in arrayList)
            {
                if (t > max)
                {
                    max = t;
                }
            }
            foreach (double x in arrayList)
            {
                if (x < min)
                {
                    min = x;
                }
            }
            int a = arrayList.IndexOf(min);
            int b = arrayList.IndexOf(max);
            maxArray.Add(max);
            minArray.Add(min);
            arrayList.Remove(min);
            arrayList.Remove(max);
        }
        double sumMax = 0;
        double sumMin = 0;
        double avgMin = 0;
        double avgMax = 0;
        foreach (double x in maxArray)
        {
            sumMax += x;
        }
        foreach (double x in minArray)
        {
            sumMin += x;
        }
        avgMax = sumMax / 3;
        avgMin = sumMin / 3;
        Console.WriteLine("Avarage of max numbers : " + avgMax);
        Console.WriteLine("Avarage of min numbers : " + avgMin);
        Console.WriteLine("Sums of avarage : " + (avgMin + avgMax));

    }

    public void ThirdQuestion()
    {
        Console.WriteLine("Enter sentence: ");
        string s = Console.ReadLine();
        char[] vowelLetter = { 'a' ,'A', 'e', 'E', 'ı', 'I', 'i' , 'I', 'o', 'O', 'ö', 'Ö', 'u', 'U', 'ü', 'Ü'};
        ArrayList list = new ArrayList();
        for (int i = 0; i < s.Length; i++)
        { 
            for(int j = 0; j < vowelLetter.Length; j++)
            {
                if (s[i] == vowelLetter[j])
                {
                    list.Add(vowelLetter[j]);
                }
            }
        }
        list.Sort();
        foreach(var i in list)
        {
            Console.WriteLine(i);
        }
        
     }
}

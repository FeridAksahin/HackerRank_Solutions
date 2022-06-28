using System;

namespace MyApp  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeQuestions instance = new SomeQuestions();
            //  instance.IsOdd();
            //instance.Question2();
            //instance.Question3();
            instance.Question4();
        }
    }
}


class SomeQuestions
{
    public void IsOdd()
    {

        /*
      Ask the user to enter a positive number(n). Then ask the user to enter n positive numbers. Print the even numbers that the user has entered to the console.
         */
        Console.WriteLine("Enter length number");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] ar = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.Write("Enter {0}. number: ", i + 1);
            ar[i] = Convert.ToInt32(Console.ReadLine());
        }


        foreach (int i in ar)
        {
            if (i % 2 == 0 && i > 0)
            {
                Console.Write(i + " ");
            }
        }
    }




    public void Question2()
    {
        /*
Ask the user to enter two positive numbers (n, m). Then ask the user to enter n positive numbers. From the numbers entered by the user, print the numbers that are divisible by m to the console.
 */
        Console.WriteLine("Enter length number");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] ar = new int[len];

        Console.WriteLine("Enter 'm' number");
        int m = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < len; i++)
        {
            Console.Write("Enter {0}. number: ", i + 1);
            ar[i] = Convert.ToInt32(Console.ReadLine());
        }


        foreach (int i in ar)
        {
            if (i % m == 0 || i == 0)
            {
                Console.Write(i + " ");
            }
        }
    }


    public void Question3()
    {
        /*
         Ask the user to enter a positive number (n). Then ask the user to enter n words. Print the words entered by the user from the end to the beginning to the console.
        */
        Console.WriteLine("Enter 'n' number");
        int len = Convert.ToInt32(Console.ReadLine());

        string[] ar = new string[len];

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Enter {0}. word", i + 1);
            ar[i] = Console.ReadLine();
        }

        for (int i = len - 1; i >= 0; i--)
        {
            Console.Write(ar[i] + " ");
        }
    }

    public void Question4()
    {
        //Ask the user to type a sentence. Print the total number of words and letters in the sentence to the console.
        Console.Write("Enter sentence: ");
        string sentence = Console.ReadLine();


        char[] danger = { ' ', ',', '!', '%', '|', '&', '+', '-' };
        string[] words = sentence.Split(danger);
        //string[] words = sentence.Split(' ');
      



        string nonSpaceSentence = null;
        int letter = 0;

        for(int i = 0; i<sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                nonSpaceSentence += sentence[i];
                letter++;
            }
        }
        Console.WriteLine("Number of words in the sentence is : " + words.Length);
        Console.WriteLine("Number of letters in the sentence : " + letter);

    }

}



using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'findDigits' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int findDigits(int n)
    {
        string numString = Convert.ToString(n);
        string[] ar = new string[numString.Length];

        for (int i = 0; i < numString.Length; i++)
        {
            if (i == 0)
            {
                ar[i] = numString.Substring(i, i + 1);
            }
            else
            {
                ar[i] = numString.Substring(i, 1);
            }
        }

        int count = 0;
        int[] array = new int[ar.Length];

        for (int i = 0; i < ar.Length; i++)
        {
            array[i] = Convert.ToInt32(ar[i]);
            if (array[i] == 0)
            {
                continue;
            }
            else if (n % array[i] == 0)
            {
                count++;
            }
        }

        return count;



    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.findDigits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}


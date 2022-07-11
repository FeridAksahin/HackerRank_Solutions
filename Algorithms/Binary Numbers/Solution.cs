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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string binary = Convert.ToString(n, 2); //convert binary
        int countA = 1;
        int countB = 1;
        int countC = 0;
        int ans = 0;
        for(int i = 0; i < binary.Length-1; i++)
        {
           
            if(binary[i] == '1' && binary[i+1] == '1')
            {
                countB++;
                countC++;
             
            }
            else if (binary[i+1] == '0')
            {
                if(countA < countB)
                {
                    countA = countB;
                }
                countB = 1;
            } 
        }
        if (countC == 0)
        {
            ans = 1;
            Console.WriteLine(ans);
        }
        else if (binary.Contains('0'))
        {
           if(countB < countA)
            Console.WriteLine(countA);
           else
                Console.WriteLine(countB);
        }
        else if (!(binary.Contains('0')))
        {
            Console.WriteLine(binary.Length);
        }
      
    }
}

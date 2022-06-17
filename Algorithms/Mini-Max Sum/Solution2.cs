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


    public static void miniMaxSum(List<int> arr)
    {
        long sum=0;
        long max=0;
        long min=0;
        
        for (var i = 0; i < 5; i++)
        {
            sum=sum + arr[i] ;          
        }
        min=arr.Min();    
        max=arr.Max(); 
        long minValue = sum - max;
        long maxValue= sum - min;

        Console.WriteLine(minValue + " " +maxValue);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

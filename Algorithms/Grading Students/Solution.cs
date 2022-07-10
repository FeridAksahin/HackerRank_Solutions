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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {

        List<int> list = new List<int>();
        
        int num = 0;
        string s = null;
        foreach (int i in grades)
        {
            if (i < 38)
            {
                list.Add(i);
            }
            else if (i >= 38 && i < 100)
            {
                s = Convert.ToString(i);//for example i = 77
                string se = s[1]+"";
                if (Convert.ToInt32(se) > 5)  
                {
                    
                    s = s[0] + "0";
                    num = Convert.ToInt32(s);//num == 70
                    num += 10; // num = 80

                    if (num - i < 3) //80-77 = 3 
                    {
                        list.Add(num);
                    }
                    else
                    {
                        list.Add(i);
                    }
                }
                else if (Convert.ToInt32(se) < 5) //for example i=73
                {
                   
                    s = s[0] + "5"; //s = 75
                    num = Convert.ToInt32(s);
                    if (num - i < 3)
                    {
                        list.Add(num);
                    }
                    else
                    {
                        list.Add(i);
                    }

                }
                else if(Convert.ToInt32(se) == 5)
                {
                    list.Add(i);
                }
            }
            else
            {
                list.Add(i);
            }
        }
        return list;

    }

}

class Solution
{
    public static void Main(string[] args)
    {


        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));


    }
}
//https://www.hackerrank.com/challenges/grading/problem
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
        

        string s = Console.ReadLine();

            string[] ar = s.Split(':','A','M','P');
        int one = Convert.ToInt32(ar[0]);

        
        if (one <= 11 && one >= 1 && s.EndsWith("PM"))
        {
            one = one + 12;
            string ss = Convert.ToString(one);
            Console.WriteLine(ss + ":" + ar[1] + ":" + ar[2]);
        }
        else if(one == 12 && s.EndsWith("AM"))
        {
            string stram = "00";
            
            Console.WriteLine(stram + ":" + ar[1] + ":" + ar[2]);
        }
        else{
            Console.WriteLine(ar[0] + ":" + ar[1] + ":" + ar[2]);
        }
    }
}

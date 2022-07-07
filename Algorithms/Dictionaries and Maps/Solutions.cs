using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        long n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneNum = new Dictionary<string, string>();
        string[] info = new string[2];
        string s;
        for (int i = 0; i < n; i++)
        {
            s = Console.ReadLine();
            info = s.Split(' ');
            phoneNum.Add(info[0], info[1]);
            Array.Clear(info);
        }
        string[] ar = new string[n];
        for (int i = 0; i < n; i++)
        {
            string c = Console.ReadLine();
            ar[i] = c;
        }  


        for (int b = 0; b < n; b++)
        {
            if (ar[b] != null)
            {
                if (phoneNum.ContainsKey(ar[b]))
                {
                    Console.WriteLine(ar[b] + "=" + phoneNum[ar[b]]);
                }

                else
                {
                    Console.WriteLine("Not found");
                }
            }

        }
    }
}

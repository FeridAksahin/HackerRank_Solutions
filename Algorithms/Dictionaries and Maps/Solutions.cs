using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());
        string s;
        string[] str = new string[2];
        Dictionary<string, string> phoneNumber = new Dictionary<string, string>();
        for (int i = 0; i < n; i++)
        {

            s = Console.ReadLine();
            str = s.Split(' ');
            phoneNumber.Add(str[0], str[1]);
            Array.Clear(str);
        }
        for (int i = 0; i < phoneNumber.Count; i++)
        {
            string query = Console.ReadLine();

            if (query != null)
            {
                if (phoneNumber.ContainsKey(query))
                {
                    Console.WriteLine(query + "=" + phoneNumber[query]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
        /*
                or foreach
                foreach (var phone in phoneNumber.Keys)
               {
                   string query = Console.ReadLine();

                   if (query != null)
                   {
                       if (phoneNumber.ContainsKey(query))
                       {
                           Console.WriteLine(query + "=" + phoneNumber[query]);
                       }
                       else
                       {
                           Console.WriteLine("Not found");
                       }
                   }
               }
                */
    }
}


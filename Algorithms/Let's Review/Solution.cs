using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int a = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i<a; i++){
            string str = "";
            str = Console.ReadLine();
             string even="";
             string odd="";
        for(int j =0; j<str.Count(); j++){
            if(j%2==0){
                even = even+str[j];
            }
            else{
                odd = odd+str[j];
            }
        }
        Console.WriteLine(even+" "+odd);
        }
    }
  
}

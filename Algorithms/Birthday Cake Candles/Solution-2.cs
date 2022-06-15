using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);  
         
         int max = 0;
         int sayi = 0;
         max=arr[0];
         for(int i = 0; i<arr.Length; i++){
             if(arr[i]>max){
                 max=arr[i];
             }
             else if (arr[i] == max){
                 sayi++;
             }
         }
            Console.WriteLine(sayi);
    }
}


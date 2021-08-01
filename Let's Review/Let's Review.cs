using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int stringCount =Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < stringCount; i++)
        {
           string s = Console.ReadLine();
           string evens = "" , odds = "";
           for(int k = 0; k < s.Length; k++)
           {
                if(k % 2 == 0)
                {
                     evens = evens + s[k];   
                }
                else
                {
                    odds = odds + s[k];    
                }    
           }
           Console.WriteLine("{0} {1}",evens,odds);
        }
    }
    
}

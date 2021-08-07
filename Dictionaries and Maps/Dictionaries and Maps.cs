using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32((Console.ReadLine()));
        Dictionary<string, string> dic = new Dictionary<string, string>();
        for(int i = 0; i < n ; i++)
        {
            
          string[] output = Console.ReadLine().Split(' ');
          dic.Add(output[0], output[1]);  
        }
        string output1 = " ";
        while((output1 = Console.ReadLine()) != null)
        {
          string value;
          if (dic.TryGetValue(output1, out value))
          {
             Console.WriteLine(string.Concat(output1,"=",value)); 
          }
          else
          {
              Console.WriteLine("Not found");
          }
        }
    }
}
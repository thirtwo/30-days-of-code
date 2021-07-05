using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int j;
        double f;
        string a;
        // Declare second integer, double, and String variables.
        j = Convert.ToInt32(Console.ReadLine());
        f = Convert.ToDouble(Console.ReadLine());
        a = Console.ReadLine();
        // Read and save an integer, double, and String to your variables.
        Console.WriteLine(i + j);
        Console.WriteLine(String.Format("{0:0.0}" , d + f));
        Console.WriteLine(s + a);
        // Print the sum of both integer variables on a new line.
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
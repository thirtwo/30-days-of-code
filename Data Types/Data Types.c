#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {
    int i = 4;
    double d = 4.0;
    char s[] = "HackerRank ";

    
    // Declare second integer, double, and String variables.
    
    int j;
    double f;
    char a[105];
    // Read and save an integer, double, and String to your variables.
    scanf("%d",&j);
    scanf("%lf", &f);
    scanf("%*[\n]%[^\n]%*c", a); //read until \n and discard it. read until \n and save it inside of an array
    // Print the sum of both integer variables on a new line.
    printf("%d\n", i+j);
    // Print the sum of the double variables on a new line.
    printf("%.1lf\n", d+f);
    // Concatenate and print the String variables on a new line
    // The 's' variable above should be printed first.
    printf("%s%s", s,a);
    return 0;
}
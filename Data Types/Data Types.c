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
    int counter =0;
    while (1) 
    {
    scanf("%c",&a[counter]);
    if(a[counter] == EOF || a[counter] == '\n')
    break;
    counter++;
    }
    scanf("%[^\n][^\r]%*c", a);
    // Print the sum of both integer variables on a new line.
    printf("%d\n", i+j);
    // Print the sum of the double variables on a new line.
    printf("%.1lf\n", d+f);
    // Concatenate and print the String variables on a new line
    // The 's' variable above should be printed first.
    printf("%s%s", s,a);
    return 0;
}
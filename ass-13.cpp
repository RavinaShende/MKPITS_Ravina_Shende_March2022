#include<stdio.h>
#include<stdlib.h>
int main()
{
    int a,b,c,w, max;
    printf("\nInput the first integer: "); 
    scanf("%d", &a);
    printf("\nInput the second integer: ");
    scanf("%d", &b);
    printf("\nInput the third integer: ");
    scanf("%d", &c); 
    w=(a+b+abs(a-b))/2;
    max=(w+c+abs(w-c))/2;
    printf("\nMaximum value of three integers: %d", max);
	printf("\n");
}
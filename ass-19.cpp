#include<stdio.h>
#include<conio.h>
main() 
{
	int p, q, r, s;
	printf("Enter 4 integer number (P,Q,R,S):");
	scanf("%d%d%d%d",&p,&q,&r,&s);	    

    if((r>0) && (s>0) && (p%2==0) && (q>r) && (s>p) && ((r+s)>(p+q)))
    {
		printf("\nCorrect values");
	} 
	else 
	{
		printf("\nWrong values");
	}
}
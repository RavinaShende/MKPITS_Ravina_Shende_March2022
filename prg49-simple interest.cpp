#include<stdio.h>
#include<conio.h>
main()
{
	int p,r,t,res;
	printf("Enter Principle, rate of interest & time (years) to find simple interest : \n");
	scanf("%d %d %d",&p,&r,&t);
	res=(p*r*t)/100;
	printf("Simple Interest = %d",res);
}
#include<stdio.h>
#include<conio.h>
main()
{
	double w1,w2,c1,c2, res;
	printf("weight - item 1:");
	scanf("%lf",&w1);
	printf("no. of item 1:");
	scanf("%lf",&c1);
	printf("weight - item 2:");
	scanf("%lf",&w2);
	printf("no. of item 2:");
	scanf("%lf",&c2);
	res=((w1*c1)+(w2*c2))/(c1+c2);
	printf("Average value = %lf\n",res);
	
}
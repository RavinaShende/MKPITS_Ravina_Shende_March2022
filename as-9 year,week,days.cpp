#include<stdio.h>
#include<conio.h>
main()
{
	int num,n1,n2,n3;
	printf("enter any number");
	scanf("%d",&num);
    n1=num/365;
	num=num%365;	
	printf("years%d",n1);
	n2=num/7;
	num=num%7;
	printf("\nweeks%d",n2);
	n3=num%7;
	printf("\ndays%d",n3);
}
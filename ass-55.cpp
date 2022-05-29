#include<stdio.h>
#include<conio.h>
main()
{
	int num,a,b,c, sum=0;
	printf("Enter number less than 500:");
	scanf("%d",&num);
	if(num<=500)
	{
		a=num%10;
		num=num/10;
		b=num%10;
		num/10;
		c=num/10;
		sum = a+b+c;
	}
	printf("sum of digits of this number= %d",sum);
	
}
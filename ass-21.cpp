#include<stdio.h>
#include<conio.h>
main()
{
	int num;
	printf("Enter any integer number :");
	scanf("%d",&num);
	if (num>=0 && num<=20)
	{
		printf("range [0,20]");
	}
	else
	if (num>=21 && num<=40)
	{
		printf("range [21,40]");
	}
	else
	if (num>=41 && num<=60)
	{
		printf("range [41,60]");
	}
	else
	if (num>=61 && num<=80)
	{
		printf("range [61,80]");
	}
	else
	{
		printf("Outside the range");
	}
	return 0;
}
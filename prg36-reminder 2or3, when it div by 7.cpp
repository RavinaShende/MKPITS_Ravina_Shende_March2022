#include<stdio.h>
#include<conio.h>
main()
{
	int num1, num2,i;
	printf("Enter 1st number:");
	scanf("%d",&num1);
	printf("Enter 2nd number:");
	scanf("%d",&num2);
	printf(" The number which gives reminder as 2 or 3, when divide it by 7 are:");
	for(i=num1;i<=num2;i++)
	{
		if( i%7==2  ||  i%7==3 )
		{
			printf("%d ",i);	
		}
	}
}
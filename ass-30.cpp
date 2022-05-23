#include<stdio.h>
#include<conio.h>
main()
{
	int i,j;
	printf("Input integer number:");
	scanf("%d",&i);
	printf("List of square of each one of the even values from 1 to %d\n",i);
	for(j=0;j<=i;j++)
	{
		if ((j%2) == 0)
		{
			printf("%d^2 = %d\n",j,j*j);
		}
	}
}
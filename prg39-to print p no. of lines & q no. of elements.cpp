#include<stdio.h>
#include<conio.h>
main()
{
	int num1, num2, i, j, n=1;
	printf("Enter number of lines: ");
	scanf("%d",&num1);
	printf("Enter number of elements in a lines: ");
	scanf("%d",&num2);
	for (i=1; i<=num1; i++)
	{
		for (j=1;j<=num2; j++)
		{
			printf(" %d",n);
			n++;
		}
		printf("\n");
	}
	return 0;
}
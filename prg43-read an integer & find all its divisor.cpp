#include<stdio.h>
#include<conio.h>
main()
{
	int i,n;
	printf("Enter any number :");
	scanf("%d",&n);
	printf("All divisor of given number :\n");
	for (i=1;i<=n;i++)
	{
		if(n%i==0)
		{
			printf("%d\n",i);
		}
	}
}
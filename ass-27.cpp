#include<stdio.h>
#include<conio.h>
main()
{
	int a[20],i,j,positive=0,negative=0;
	printf("Enter any 5 number: ");
	for(i=0;i<5;i++)
	{
		scanf("%d",&a[i]);
	}
	for(i=0;i<5;i++)
	{
		if(a[i]>=0)
		{
			positive++;
		}
		else 
		if(a[i]<0)
		
		{
			negative++;
		}
	}
	printf("count of positive number=%d",positive);
	printf("\ncount of negative number=%d",negative);
	
	
	
}
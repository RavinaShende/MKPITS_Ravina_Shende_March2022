#include<stdio.h>
#include<conio.h>
main()
{
	int a[20],i,count=0;
	float avg, sum=0;
	printf("Enter any 5 number :");
	for(i=0;i<5;i++)
	{
		scanf("%d",&a[i]);
	}
	for(i=0;i<5;i++)
	{
		if(a[i]>=0)
		{
			count++;
			sum= sum+a[i];
		}
	}
	avg= sum/count;
	printf("count of positive numbers =%d",count);
	printf("\nsum of all positive numbers =%f",avg);
}
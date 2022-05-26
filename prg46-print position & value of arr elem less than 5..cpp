#include<stdio.h>
#include<conio.h>
main()
{
	int a[5],i;
	printf("Enter array element :");
	for(i=0;i<5;i++)
	{
		scanf("%d",&a[i]);
	}
	for(i=0;i<5;i++)
	{
		if(a[i] < 5)
		{
			printf("\na[%d]=%d",i,a[i]);
		}
	}
}
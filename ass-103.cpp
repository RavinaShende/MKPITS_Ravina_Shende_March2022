#include<stdio.h>
#include<conio.h>
main()
{
	int a[4],b[4],i;
	printf("Enter array element:");
	for(i=0;i<4;i++)
	{
	scanf("%d",&a[i]);
    }
	for(i=0;i<4;i++)
	{
		if(i==3)
		{
			b[0]=a[i];
		}
		else
		{
			b[i+1]=a[i];
		}
	}
	printf(" new array:");
	for(i=0;i<4;i++)
	{
		 printf("%d ",b[i]);
	}
   
}
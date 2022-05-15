#include<stdio.h>
#include<conio.h>
int main()
{
	int a[10],i,n;
	printf("Enter the size of array:");
	scanf("%d",&n);
	printf("Enter array elements:\n");
	for (i=0;i<n;i++)
	{
		printf("a[%d]=",i);
		scanf("%d",&a[i]);
	}
	for (i=0;i<n;i++)
	{
		if (a[i]==5 || a[i]==7)
		{
			printf(" %d ",a[i]);
		}
		else
		printf("%d ",0);		
	}
}
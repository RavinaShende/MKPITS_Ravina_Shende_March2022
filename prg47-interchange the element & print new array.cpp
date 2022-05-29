#include<stdio.h>
#include<conio.h>
main()
{
	int a[10],b[10],i,n,temp=0;
	printf("Enter array size:\n");
	scanf("%d",&n);
	printf("Enter array element:\n");
	for(i=0;i<n;i++)
	{
		printf("a[%d]=",i);
		scanf("%d",&a[i]);
	}
	for(i=0;i<n;i++)
	{
		temp=a[i];
		a[i]=a[n-(i+1)];
		a[n-(i+1)]=temp;
	}
	printf("New array :\n");
	for(i=0;i<n;i++)
	{
		printf("b[%d]=%d\n",i,a[n-(i+1)]);
	}
}
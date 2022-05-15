#include<stdio.h>
#include<conio.h>
int main()
{
	int i,a[10],n,count=0;
	printf("Enter size od array:");
	scanf("%d",&n);
	printf("Enter array element:");
	for(i=0;i<=n;i++)
	{
	scanf("%d",&a[i]);
	}
    for (i=0;i<=n;i++)
    {
    	if (a[i]==5 && a[i+1]==5)
		{
		count=count+1;	
		}
    }
    	printf("count=%d",count);
}

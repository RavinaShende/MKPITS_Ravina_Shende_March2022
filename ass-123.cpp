#include<stdio.h>
#include<conio.h>
int main()
{
	int a[10];
	int i,n,count=0;
	printf("enter size of array:");
	scanf("%d",&n);
	printf("Enter array elements:\n");
	for (i=0;i<n;i++)
	{
		printf("a[%d]=",i);
		scanf("%d",&a[i]);
	}
	for (i=0;i<n;i++)
	{
		if ( a[i]==5 )  
		{
			count = count+1;
		}   	
	}
    	if (count==3)
  	    {
		    printf("True");
     	}
	    else 
	        printf("False");
}
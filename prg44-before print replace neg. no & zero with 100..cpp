#include<stdio.h>
#include<conio.h>
int main() 
{
	int a[7],i,num;
	printf("Enter array element :\n");
	for(i=0;i<7;i++) 
	{
		scanf("%d",&num);
		
		if(num>0) 
		{			
		    a[i]=num;
		} 
		else
		{
			a[i]=100;
		}
	}
	printf("Array values are: \n");
	for(i=0;i<7;i++) 
	{
		printf("a[%d] = %d\n", i,a[i]);
	}
}
#include<stdio.h>
#include<conio.h>
main() 
{
	int a[7], i, num;
	printf("Enter array element:\n");
	scanf("%d", &num);
	for(i=0;i<7;i++) 
	{
		a[i] = num;
		num = 3*num;
	}
	for(i=0;i<7;i++)
	{
		printf("a[%d] = %d\n", i, a[i]);
	}
}
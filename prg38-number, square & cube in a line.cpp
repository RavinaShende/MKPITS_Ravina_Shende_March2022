#include<stdio.h>
#include<conio.h>
int main()
{
	int n, i, a, b, c;
	printf("Enter number of lines :");
	scanf("%d",&n);
	printf("\nNumber, Square, Cube\n");
	for (i=1; i<=n; i++)
	{
		a=i;
		b=a*i;
		c=b*i;
		printf("\n  %d    %d    %d\n",a,b,c);
	//	printf("\n\n    %d     %d     %d \n", i, i*i, i*i*i);
	}
	return 0;
}
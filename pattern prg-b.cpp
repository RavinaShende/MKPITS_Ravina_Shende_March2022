#include<stdio.h>
#include<conio.h>
int main()
{
	int r,sp,i;
	for (r=1;r<=4;r++)
	{
		for(sp=1;sp<=51-r;sp++)
		{
			printf(" ");
		}
		for(i=1;i<=r;i++)
		{
			printf(" %d",r);
		}
		printf("\n");
	}
}
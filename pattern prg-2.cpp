#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,n=1;
	for (r=1;r<=4;r++)
	{
		for (sp=1;sp<=41-r;sp++)
		{
			printf("  ");
		}
		for(c=1;c<=r;c++)
		{
			printf(" %d",n);
			n++;
		}
		n=n-2;
		for (c=1;c<r;c++)
		{
			printf(" %d",n);
			n--;
		}
		n=1;
		printf("\n");
	}
}
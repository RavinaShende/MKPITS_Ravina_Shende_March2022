#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,count=0;
	for (r=1;r<=3;r++)
	{
		for(sp=1;sp<=51-r;sp++)
		{
			printf(" ");
		}
		for (c=1;c<=r;c++)
		{
			printf("%d",r);
		}
		printf("\n");
	}
}
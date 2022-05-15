#include<stdio.h>
#include<conio.h>
main()
{
	int r,sp,str;
	for (r=1;r<=3;r++)
	{
		for(sp=1;sp<=51-r;sp++)
		{
			printf(" ");
		}
		for (str=1;str<=r;str++)
		{
			printf("*");
		}
		printf("\n");
	}
}
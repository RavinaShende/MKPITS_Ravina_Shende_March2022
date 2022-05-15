#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp;
	for (r=5;r>=1;r--)
	{
		for(sp=51;sp<=51-r;sp++)
		{
			printf(" ");
		}
		for (c=1;c<=r;c++)
		{
			printf("%c",70-c);
		}
		printf("\n");
	}
}
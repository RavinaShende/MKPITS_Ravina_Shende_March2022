#include<stdio.h>
#include<conio.h>
main()
{
	int r,c;
	for(r=5;r>=1;r--)
	{
		for(c='E';c>='A';c--)
		{
			printf("%c",c);
		}
		printf("\n");
	}
}
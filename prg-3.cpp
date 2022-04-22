#include<stdio.h>
#include<conio.h>
main()
{
	char r,c;
	for(r=5;r>=1;r--)
	{
		for(c=1;c<=r;c++)
		{
			printf("%c",'*');
		}
		printf("\n");
	}
}
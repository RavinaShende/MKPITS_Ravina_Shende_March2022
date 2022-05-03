#include<stdio.h>
#include<conio.h>
main()
{
	int r,c;
	for(r=1;r<=3;r++)
	{
		for(c=1;c<=4;c++)
		{
			printf("%c",64+c);
		}
		
		printf("\n");
	}
}
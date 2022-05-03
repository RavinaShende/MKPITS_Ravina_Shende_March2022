#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,i=0;
	for(r=1;r<=4;r++)
	{
		for(c=1;c<=r;c++)
		{
			i=i+1;
			printf("%d",i);
		
		}
		printf("\n");
	}
	
	printf("\n");
}
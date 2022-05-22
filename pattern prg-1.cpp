#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,ch=64;
	for (r=1;r<=4;r++)
	{
		for (sp=1;sp<=41-r;sp++)
		{
			printf("  ");
		}
		for(c=r;c>=1;c--)
		{
			printf(" %c",64+c);
			ch--;
		}
		ch=65;
		for (c=1;c<r;c++)
		{
			printf(" %c",65+c);
			ch++;
		}
		ch=c;
		printf("\n");
	}
}
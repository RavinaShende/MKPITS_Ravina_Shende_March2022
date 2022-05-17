#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,n=65;
	for (r=1;r<=7;r++)
	{
		for(sp=1;sp<=41-r;sp++)
		{
			printf(" ");
		}
		if (r==1 || r==3 || r==5 || r==7)
		{
		for (c=1;c<=r;c++)
		{
			printf("%c ",n);
			n++;
		}
	    }
	    n=65;
	    printf("\n");
	}
}
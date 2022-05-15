#include<stdio.h>
#include<conio.h>
int main()
{
	int r,sp,str;
	for (r=1;r<=4;r++)
	{
		for(sp=1;sp<=81-r;sp++)
		{
			printf(" ");
		}
		for(str=1;str<=r;str++)
		{
			printf(" *");
		}
		printf("\n");
	}
}
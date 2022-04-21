#include<stdio.h>
#include<conio.h>
main()
{
	int i,r,v;
	printf("voltage");
	scanf("%d",&v);
	printf("resistance");
	scanf("%d",&r);
    i=v/r;
	printf("current %d",i);
}
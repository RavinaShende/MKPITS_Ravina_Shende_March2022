#include<stdio.h>
#include<conio.h>
main()
{
	int nodays,y,m,d;
	printf("Enter number of days:");
	scanf("%d",&nodays);
	y=nodays/365;
	nodays=nodays-(y*365);
	m=nodays/30;
	nodays=nodays-(m*30);
	d=nodays/1;
	printf("%d Year \n%d Month \n%d Day",y,m,d);
}
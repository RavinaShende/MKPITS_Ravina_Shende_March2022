#include<stdio.h>
#include<conio.h>
main() 
{
	int num, h, m, s;
	printf("Input seconds: ");
	scanf("%d", &num);
	
	h = (num/3600); 
	
	m = (num -(3600*h))/60;
	
	s = (num -(3600*h)-(m*60));
	
	printf("H:M:S - %d:%d:%d\n",h,m,s);
}
#include<stdio.h>
#include<conio.h>
main()
{
	int f,r,t,sin90=1;
	printf("enter radius r");
	scanf("%d",&r);
	printf("enter force F");
	scanf("%d",&f);
	t=r*f*sin90;
	printf("Torque, T= %d",t);
}
#include<stdio.h>
#include<conio.h>
#include<math.h>
main()
{
	double a, b, c, x, y, pr1;
	printf("Enter 1st number (a):");
	scanf("%lf",&a);
	printf("Enter 2nd number (b):");
	scanf("%lf",&b);
	printf("Enter 3rd number (c):");
	scanf("%lf",&c);
	pr1=(b*b)-4*(a)*(c);
	pr1=sqrt(pr1);
	if(pr1>0 && a!=0)
	{
		x=((-b + pr1)/(2*a));
		y=((-b - pr1)/(2*a));
		printf("Root 1 =%.5lf\n",x);
		printf("Root 2 =%.5lf\n",y);
	}
	else
	{
		printf("Not possible to find the roots");
	}
}
#include<stdio.h>
#include<conio.h>
main()
{
	double inch, cm;
	printf("Input the distance in centimeter :\n");
	scanf("%lf",&cm);
	inch = cm / 2.54;
	printf("Distance of %0.2lf cms is = %.2lf inches",cm,inch);
}
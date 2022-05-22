#include<stdio.h>
#include<conio.h>
main()
{
	float a,b,c,p;
	printf("Input 1st number:");
	scanf("%f",&a);
	printf("Input 2nd number:");
	scanf("%f",&b);
	printf("Input 3rd number:");
	scanf("%f",&c);
	if ( (a+b)>c  &&  (a+c)>b  && (b+c)>a)
	{
		p=a+b+c;
		printf("\nPerimeter of triangle = %.1f",p);
	}
	else
	{
		printf("Not possible to create a triangle");
	}
}
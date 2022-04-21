#include<stdio.h>
#include<conio.h>
main()
{
	float pi=3.14, r, h, V;
	printf("radius of cone");
	scanf("%f",&r);
	printf("height of cone");
	scanf("%f",&h);
    V=(pi*r*r*h)/3;
	printf("Volume of cone %f",V);
}
#include<stdio.h>
#include<conio.h>
main()
{
	int a, v, u,t=5;
	printf("final velocity");
	scanf("%d",&v);
    printf("initial velocity");
	scanf("%d",&u);
	a=(v-u)/t;
	printf("Accelration a= %d",a);
}
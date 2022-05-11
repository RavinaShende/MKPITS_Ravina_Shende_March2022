                        //s=1+3/2+5/4+7/8.==4.625
#include<stdio.h>
#include<conio.h>
main()
{
double i,d,j=1,sum=0;
for(i=1;i<=7;i++)
	{
		d= (i / j );
		sum=sum + d;
		i=i+2;
		j=j*2;
	}
printf("Value of s = %lf",sum);
}
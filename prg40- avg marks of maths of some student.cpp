#include<stdio.h>
#include<conio.h>
int main()
{
	int marks,n=0,t=0;
	float avg;
	printf("Enter mathematical marks (0 to terminate):\n");
	printf("Enter marks of Roll no. 1 :");
	scanf("%d",&marks);
	while(marks>0)
	{
		t=t+marks;
		n=n+1;
		printf("Enter marks of Roll no. %d :",n+1);
	    scanf("%d",&marks);
	}
	avg=(float)t/(float)n;
	printf("Average marks in maths:%2f\n",avg);
	
}
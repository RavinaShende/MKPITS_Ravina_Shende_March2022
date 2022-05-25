#include<stdio.h>
#include<conio.h>
main()
{
	char id[10];
	int hour;
	double value, salary;
	printf("Input the employee ID :\n");
	scanf("%s",&id);
	printf("Input the working hours :\n");
	scanf("%d",&hour);
	printf("Salary amount per hour :\n");
	scanf("%lf",&value);
	salary=value*hour;
	printf("Employee ID : %s\n",id );
	printf("Salary : %0.2lf Rupees ",salary);
}
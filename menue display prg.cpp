#include<stdio.h>
#include<conio.h>
main()
{
	int choice, num1, num2, res;
	printf("press 1 for addition");
	printf("\npress 2 for substraction");
	printf("\npress 3 for multiplication");
	printf("\npress 4 for division");
	printf("\nenter your choice");
	scanf("%d", &choice);
	if(choice==1)
	{
		printf("enter two number");
		scanf("%d%d",&num1, &num2);
		res=num1+num2;
		printf("addition of two number is %d", res);
	}else
	if(choice==2)
	{
	printf("enter two number");
		scanf("%d%d",&num1, &num2);
		res=num1-num2;
		printf("substraction of two number is %d", res);	
	}else
	if(choice==3)
	{
		printf("enter two number");
		scanf("%d%d",&num1, &num2);
		res=num1*num2;
		printf("multiplication of two number is %d", res);
	}else
	if(choice==4)
	{
		printf("enter two number");
		scanf("%d%d",&num1, &num2);
		res=num1/num2;
		printf("division of two number is %d", res);
	}else
	printf("Invalid choice");
	
}

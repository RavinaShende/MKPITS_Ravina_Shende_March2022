#include<stdio.h>
#include<conio.h>
main()
{
	int choice, num1, num2, res;
	printf("Press + for addition\nPress - for substraction\nPress * for multiplication\nPress / for division");
	printf("\nenter your choice");
	scanf("%c", &choice);
	if (choice=='+')
	{
		printf("enter any two number");
		scanf("%d%d", &num1, &num2);
		res=num1+num2;
		printf("addition of two numbers %d", res);
	}else
	if (choice=='-')
	{
		printf("enter any two number");
		scanf("%d%d", &num1, &num2);
		res=num1-num2;
		printf("substraction of two numbers %d", res);
	}else
	if (choice=='*')
	{
		printf("enter any two number");
		scanf("%d%d", &num1, &num2);
		res=num1*num2;
		printf("multiplication of two numbers %d", res);
	}else
	if (choice=='/')
	{
		printf("enter any two number");
		scanf("%d%d", &num1, &num2);
		res=num1/num2;
		printf("division of two numbers %d", res);
	}else
	{
		printf("Invalid choice");
	}
}
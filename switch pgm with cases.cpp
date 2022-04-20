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
	switch (choice)
	{
	    case 1:
		printf("enter any two nos");
		scanf("%d%d", &num1, &num2);
		res=num1+num2;
		printf("addition of two nos is %d",res);
		break;
		case 2:
		printf("enter any two nos");
		scanf("%d%d", &num1, &num2);
		res=num1-num2;
		printf("substraction of two nos is %d",res);
		break;
		case 3:
		printf("enter any two nos");
		scanf("%d%d", &num1, &num2);
		res=num1*num2;
		printf("multiplication of two nos is %d",res);
		break;
		case 4:
		printf("enter any two nos");
		scanf("%d%d", &num1, &num2);
		res=num1/num2;
		printf("division of two nos is %d",res);
		break;
		default:
		printf("Invalid choice");
	}
}
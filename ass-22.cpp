// wap that read 5 nos & sum of all odd values between them.

#include<stdio.h>
#include<conio.h>
main()
{
	int i,num[5],sum=0;
	printf("Enter 1st number :");
	scanf("%d",&num[0]);
	printf("\nEnter 2nd number :");
	scanf("%d",&num[1]);
	printf("\nEnter 3rd number :");
	scanf("%d",&num[2]);	
	printf("\nEnter 4th number :");
	scanf("%d",&num[3]);
	printf("\nEnter 6th number :");
	scanf("%d",&num[4]);
	for (i=0;i<5;i++)
	{
		if(num[i]%2 != 0)
		{
			sum= sum+num[i];
		}
	}
	printf("\nSum of all odd values=%d",sum);
	printf("\n");
}
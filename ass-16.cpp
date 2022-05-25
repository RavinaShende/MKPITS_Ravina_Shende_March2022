#include<stdio.h>
#include<conio.h>
main() 
{
	int amt, total;
	printf("Enter any amount: ");
	scanf("%d",&amt);
	printf("There are: ");
	
	total = amt/2000;    //mul. of 2000
	printf(" \n%d Note(s) of 2000.00\n", total);
	amt = amt-(total*2000);   //bal.
	
	total = amt/500;    //mul. of 500
	printf(" %d Note(s) of 500.00\n", total);
	amt = amt-(total*500);   //bal.
	
	total = amt/100;    //mul. of 100
	printf(" %d Note(s) of 100.00\n", total);
	amt = amt-(total*100);   //bal.
	
	total = amt/50;   // mul. of 50
	printf(" %d Note(s) of 50.00\n", total);
	amt = amt-(total*50);   // bal.
	
	total = amt/20;     //mul. of 20	
	printf(" %d Note(s) of 20.00\n", total);
	amt = amt-(total*20);    //bal.
	
	total = amt/10;     //mul of 10
	printf(" %d Note(s) of 10.00\n", total);
	amt = amt-(total*10);   //bal.
	
	total = amt/5;    //mul of 5
	printf(" %d Note(s) of 5.00\n", total);
	amt = amt-(total*5);  //bal
	
	total = amt/2;   //mul. of 2
	printf(" %d Note(s) of 2.00\n", total);
	amt = amt-(total*2);
	
	total = amt/1;  //mul. of 1
	printf(" %d Note(s) of 1.00\n", total);

}

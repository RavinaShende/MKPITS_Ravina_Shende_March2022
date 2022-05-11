#include<stdio.h>
#include<conio.h>

struct student
{
	int id; 
   char name[20];
};
main()
{
	struct student s1={45,"raj"};      //structure constant
	printf("student id=%d",s1.id);
    printf("\nstudent name=%s",s1.name);
}
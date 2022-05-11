#include<stdio.h>
#include<conio.h>

	union student
{
	
   int id; 
   char name[20];

}s1;
int main()
{
	printf("enter student id ");
	scanf("%d",&s1.id);
	printf("\nstudent id=%d",s1.id);
	printf("\nenter student name ");
	scanf("%s",&s1.name);
    printf("\nstudent name=%s",s1.name);
}
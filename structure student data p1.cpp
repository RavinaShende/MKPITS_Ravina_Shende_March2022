#include<stdio.h>
#include<conio.h>

struct student
{
	
   int id; 
   char name[20];

}s1;
int main()
{
	printf("enter student id");
	scanf("%d",&s1.id);
	printf("enter student name\n");
	scanf("%s",&s1.name);
	printf("student id=%d",s1.id);
    printf("\nstudent name=%s",s1.name);
}
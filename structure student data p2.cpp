#include<stdio.h>
#include<conio.h>

	struct student
{
	
   int id; 
   char name[20];

};
main()
{
	struct student s1;
	printf("enter student id\n");
	scanf("%d",&s1.id);
	printf("enter student name\n");
	scanf("%s",&s1.name);
	printf("student id=%d",s1.id);
    printf("\nstudent name=%s",s1.name);
}
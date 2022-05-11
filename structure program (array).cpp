#include<stdio.h>
#include<conio.h>

struct stud
{
	int id;
	char name[20];
};
main()
{
	int i;
	struct stud s[4];
	for(i=0;i<=4;i++)
	{
		printf("enter student id ");
		scanf("%d",&s[i].id);
		printf("enter student name ");
		scanf("%s",&s[i].name);
	}
	for(i=0;i<=4;i++)
	{
	printf("\nstudent id=%d",s[i].id);
    printf("\nstudent name=%s",s[i].name);
    }
}
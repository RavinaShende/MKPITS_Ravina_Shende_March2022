#include<stdio.h>
#include<conio.h>
#include<math.h>
main()
{
    int x1, y1, x2, y2; 
	float dist;
	printf("Enter coordinates of 1st point (x,y): ");
	scanf("%d%d", &x1,&y1);
    printf("Enter coordinates of 2nd point (x,y): ");
	scanf("%d%d", &x2,&y2);
    dist = ((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1));
	printf("Distance between the two given points: %.4f", sqrt(dist));
	printf("\n");
}
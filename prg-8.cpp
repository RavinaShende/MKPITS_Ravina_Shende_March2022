#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,ch='a';
	for(r=1;r<=4;r++)
	{
		for(c=1;c<=5;c++)
		{
			if(r%2!=0)
			{
			printf("%d",c);
			}
		    if(r%2==0)
		    {
		    printf("%c",ch);
			}
	    	
		}
		printf("\n");
		
	}
}
#include <stdio.h>
#include <stdlib.h>
#include <stdlib.h>

void find_frequency(char [], int []);

int main()
{

    int len1, len2;
    char string1[50], string2[50] ;

    printf("\nEnter the string 1 :\n");
    gets(string1);
    strupr(string1);
    len1 = strlen(string1);

    printf("\nEnter the string 2 :\n");
    gets(string2);
    strupr(string2);
    len2 = strlen(string2);

    printf("\n String1 = %s\n String2 = %s \n",string1, string2);


   int c, Sum = 0, count1[26] = {0};
   int count2[26] = {0};
   int countdiff[26] = {0};


   find_frequency(string1, count1);
   ///printf("Character Count\n");
   for (c = 0 ; c < 26 ; c++)
   {
     ///  printf("%c \t  %d\n", c + 'a', count1[c]);
   }



   find_frequency(string2, count2);
  /// printf("Character Count\n");
   for (c = 0 ; c < 26 ; c++)
   {
     ///  printf("%c \t  %d\n", c + 'A', count2[c]);
   }


   for (c = 0 ; c < 26 ; c++)
   {
       countdiff[c] = abs(count1[c] - count2[c]);

      /// printf("Diff. of %c \t  %d\n",c + 'A',  countdiff[c]);
   }


   for (c = 0; c < 26 ; c++)
   {
       Sum +=countdiff[c];
   }
   printf("\nSum is : %d \n\n\n\n",Sum);



switch (Sum)
    {
        case 1:
             ///	1	S
             printf("S");
             break;

        case 2:
             ///	2	E
             printf("E");
             break;

        case 3:
             ///	3	F
             printf("F");
             break;

        case 4:
             ///	4	E
             printf("E");
             break;
        case 5:
             ///	5	F
             printf("F");
             break;

        case 6:
             ///	6	M
             printf("M");
             break;

        case 7:
             ///	7	E
             printf("E");
             break;

        case 8:
             ///	8	A
             printf("A");
             break;

        case 9:
             ///	9	E
             printf("E");
             break;

        case 10:
             ///	10	L
             printf("L");
             break;

        case 11:
             ///	11	M
             printf("M");
             break;

        case 12:
             ///	12	A
             printf("A");
             break;

        case 13:
             ///	13	A
             printf("A");
             break;

        case 14:
             ///	14	F
             printf("F");
             break;

        case 15:
             ///	15	M
             printf("M");
             break;

        case 16:
             ///	16	F
             printf("F");
             break;

        case 17:
             ///	17	A
             printf("A");
             break;

        case 18:
             ///	18	F
             printf("F");
             break;

        case 19:
             ///	19	F
             printf("F");
             break;

        case 20:
             ///	20	E
             printf("E");
             break;

        case 21:
             ///	21	F
             printf("F");
             break;



        default :
        printf("No Match");
    }

    printf("\n\n");
   getchar();


   return 0;

}

void find_frequency(char s[], int count[]) {
   int c = 0;

   while (s[c] != '\0') {
      if (s[c] >= 'A' && s[c] <= 'Z' )
         count[s[c]-'A']++;
      c++;
   }
}
/**
Explanation of "count[string[c]-'a']++", suppose input string begins with 'a' so c is 0 initially and string[0] = 'a' and string[0] - 'a' = 0 and
we increment count[0] i.e. 'a' has occurred one time and repeat this till the complete string is scanned.
*/
//first[a[c]-'a']++;
//a[c] - 'a' // returns 0 in case of first char as 'a'
// NOW array first[0] will be treated as counter of 'a'
// likewise first[1] will be counter of 'b'

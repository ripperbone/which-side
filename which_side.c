#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>
#include <unistd.h>


/* This program will determine which side of the street the car should be parked on.
 * December 2014
 */
 
bool is_even(int num) {
   /* return 0 for true, 1 for false */
   if (num % 2 == 0) {
      return true;   
   } else {
     return false;
   } 
}


int main(int argc, char **argv)
{
   struct tm *t;
   time_t now;
   int day;
   bool display_input = false;
   bool verbose = false;
   bool house_even = false; 
  

   int option;
   while ((option = getopt(argc, argv, "iehv")) != -1) 
   {

       switch(option)
       {
            case 'v':
               verbose = true;
               break;
            case 'h':
               fprintf(stderr, "Usage: which_side [-iehv]\n");
               return(1);
            case 'i':
               display_input = true;
               break;
            case 'e':
               house_even = true;
               break;
           case '?':
              return(1);
            default:
              break;
       }
   }


   if (display_input) 
   {
       int ch;
       while ((ch = getchar()) != EOF) 
       {
           putchar(ch);
       }

   }


   if (verbose)
   {
       printf("Verbose is on.\n");

       if (house_even)
       {
           printf("House is on even side of street.\n");
        } else {
            printf("House is on odd side of street.\n");
        }
   }

   time(&now);


   /* number of seconds since epoch */
   // printf("The current time is %d\n", (int) now);
   
   //printf("The current time is %s\n", ctime(&now));
  
   t = localtime(&now);

   if (verbose) printf("The current time is %d/%d/%d %d:%02d:%02d\n",
        1 + t->tm_mon, t->tm_mday, 1900 + t->tm_year, t->tm_hour, t->tm_min, t->tm_sec );


   day = t->tm_mday;

   if (t->tm_hour > 12) {
      if (verbose) printf("It is after noon.\n");
      /* We want to determine for tomorrow then... */ 
      
      t->tm_mday = t->tm_mday + 1;
      mktime(t);
      
      if (verbose) printf("Tomorrow the time will be %d/%d/%d %d:%02d:%02d\n",
        1 + t->tm_mon, t->tm_mday, 1900 + t->tm_year, t->tm_hour, t->tm_min, t->tm_sec );
      
      day = t->tm_mday;
   }
   

   if (is_even(day) && house_even) {
      printf("in front of house.\n");
      return(0);
   } else if (!is_even(day) && !house_even) {
      printf("in front of house.\n"); 
      return(0);
   }  else {
     printf("across the street.\n");
     return(1);
   } 
   
}


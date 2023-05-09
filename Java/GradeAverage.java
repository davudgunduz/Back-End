import java.util.Scanner;
public class GradeAverage {
   public static void main (String[] arg)
   {
     // i define variables
     int math , physics , chemistry ,turkish , music , history ; 

     // I create the scanner object
     Scanner input = new Scanner(System.in) ;
     
     // getting notes from user
     System.out.print("your math grade : ");
     math = input.nextInt() ;

     System.out.print("your physics grade : ");
     physics = input.nextInt() ;

     System.out.print("your chemistry grade : ");
     chemistry = input.nextInt() ;

     System.out.print("your turkish grade : ");
     turkish = input.nextInt() ;

     System.out.print("your music grade : ");
     music = input.nextInt() ;

     
     System.out.print("your history grade : ");
     history = input.nextInt() ;

     double grade = (math + physics + chemistry + turkish + music + history ) / 6 ; 

     // print the result to the screen
     System.out.println("your grade point average : "+grade); 

     // student's success status
     String result = (grade > 60 ? "Sinifi gecti" : "Sinifta kaldi");
     System.out.println(result);

   }
}

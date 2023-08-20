import java.util.Scanner;
public class leapYear {
     public static void main(String[] args) {

        // i create the scanner object
        Scanner input = new Scanner(System.in) ;

        // i define veriable
        int year ;

        // I get year information from user
        System.out.print("please enter the year : ");
        year = input.nextInt();

        if(year % 100 == 0)
        {
            if(year % 400 == 0) {
                System.out.println("a leap year : " + year);
            } else
            {
                System.out.println("not a leap year : " + year);
            }
        } else {
            if(year % 4 == 0) {
                System.out.println("a leap year : " + year);
            } else
            {
                System.out.println("not a leap year : " + year);
            }
        }
          
           }
}

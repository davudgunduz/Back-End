import java.util.Scanner;
public class expnntlnum {
    public static void main(String[] args) {
        // i define variable
        int number1 , number2 , result=1 ;

        // I create the scanner object
        Scanner input = new Scanner(System.in);

        // I'm getting the number to take the exponent from the user
        System.out.print("key in the number to be exponentiated : ");
        number1 = input.nextInt();

         // I get the power of the number to be exponentiated from the user
         System.out.print("Key in the power of the number you want to exponentiate : ");
         number2 = input.nextInt();

         for (int i = 1; i <= number2; i++) {
            result *= number1 ; 
         }

         System.out.println(result);
    }
}

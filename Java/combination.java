import java.util.Scanner;
public class combination {
    public static void main(String[] args) {
        // i define variable
        int result , number1 , number2 , fact1 = 1, fact2 = 1, fact3 = 1 ;

        // I create the scanner object
        Scanner input = new Scanner(System.in);

        // I get the item count of your set
        System.out.print("Enter the number of items in your cluster : ");
        number1 = input.nextInt();

        // I get from the user how many groups the cluster wants to be divided into
        System.out.print("How many groups do you want to divide the cluster into? : ");
        number2 = input.nextInt();

        // I calculate the factorial of the number of elements in the set for the combination calculation
        for (int i = 1; i<=number1 ; i++) {
            fact1 *= i ; 
        }
        
        // I am doing the factorial calculation of the number of groups I want to separate for the combination calculation.
        for (int i = 1; i<=number2 ; i++) {
            fact2 *= i ; 
        }

        for (int i = 1; i<=(number1-number2); i++) {
            fact3 *= i ; 
        }

        result = fact1/(fact2 * fact3) ;

        System.out.println(result);
    }
}

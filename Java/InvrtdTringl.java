import java.util.Scanner;

public class InvrtdTringl {
    public static void main(String[] args) {
        // i define variable
        int n ;

        // i create the scanner object
        Scanner input = new Scanner(System.in);

        System.out.println("please enter the number");
        n = input.nextInt();

        for (int i = n-1; 0 <= i  ; i--) {
            for (int j = 0; j < (n - i); j++) {
                System.out.print(" ");
            }
            for (int k = 1; k <= (2 * i + 1); k++) {
                System.out.print("*");
            }
            System.out.println(" ");
        }
    }
}

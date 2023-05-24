import java.util.Scanner;
public class homework2 {
    public static void main(String[] args) {
        // i define variable
        int number;

        // I create the scanner object
        Scanner input = new Scanner(System.in);

        // I get the number that the user wants to make a transaction
        number = input.nextInt();

        // I print multiples of 4 up to the keyed number
        for (int i = 4; i <= number; i *= 4) {
            System.out.println(i);
        }
        // I print multiples of 5 up to the keyed number
        for (int i = 5; i <= number; i *= 5) {
            System.out.println(i);
        }
    }   
}

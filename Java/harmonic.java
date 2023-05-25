import java.util.Scanner;
public class harmonic {
    public static void main(String[] args) {
        // i define variable
        int number  ;
        double  numHarmonic = 0;

        // i create the scanner object
        Scanner input = new Scanner(System.in) ;

        // I am getting data from user
        System.out.print("Key in the number for which you want to find the harmonic number : ");
        number = input.nextInt() ; 

        for (int i = 1; i <= number; i++) {
            numHarmonic = numHarmonic + (1.0/i) ;
        }

        System.out.print(numHarmonic);
    }
}

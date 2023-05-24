import java.util.Scanner;
public class divisibility {
    public static void main(String[] args) {

        // i create the scanner object
        Scanner input = new Scanner(System.in);

        // i define veriable
        int number , sum = 0 , j = 0 , average;

        // I get the number from the user
        System.out.println("Key in the number you want to process");
        number = input.nextInt();

        for(int i = 0; i <= number; ++i)
        {
            if(i%12 == 0)
            {
                sum += i ;
                j++;
                
            }
        }
        average = sum / j ;

        System.out.println(average);
    }
}

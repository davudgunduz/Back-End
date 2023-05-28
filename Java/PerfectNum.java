import java.util.Scanner;
public class PerfectNum {
    public static void main(String[] args) {
        // i define veriable
        int number  , sum = 0 ;

        // i create the scanner object
        Scanner input = new Scanner(System.in);

        System.out.print("please enter the number : ");
        number = input.nextInt();

        for (int i = 1; i < number; i++) {
            if(number % i == 0)
            {
                sum += i ; 
            }
        }

        if(sum == number)
        {
            System.out.print("this number is a perfect number : " + number);
        }else {
            System.out.print("this number is not a perfect number : " + number);
        }
    }
}

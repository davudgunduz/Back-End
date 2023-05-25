import java.util.Scanner;
public class sumOfDigits {
    public static void main(String[] args) {
      // i define variable
      int number , sum = 0 , modOfNumber = 0 ;
      
      // I create the scanner object
      Scanner input =  new Scanner(System.in);

      // I am getting data from user
      System.out.print("Key in the number for which you want to find the sum of the digits :");
      number = input.nextInt();

      while(number>0)
      {
        modOfNumber = number%10 ;
        sum += modOfNumber ;
        number -= modOfNumber ;
        number /= 10 ; 
      }
      System.out.println(sum);
    }
}

import java.io.Console;
import java.util.Scanner;
public class palindrom {
    static boolean isPalidrome(int number){
        int temp = number ,lastNumber , reverseNumber = 0 ;
        while(temp != 0){
            lastNumber = temp%10 ;
            
            temp /= 10 ; 
            reverseNumber = (reverseNumber*10) + lastNumber ;
           
        }

        if(reverseNumber == number){
            return true;
        }else{
            return false;
        }
        
    }
    public static void main(String[] args) {
       
        Scanner input = new Scanner(System.in);

        System.out.println("Enter the number you want to check if it is a palydrome.");
        int number = input.nextInt();
        
        if(isPalidrome(number) == true)
        {
            System.out.println("The number you enter is a palindrome number.");
        }else{
            System.out.println("The number you enter is not a palindrome number.");
        }
       
    }
}

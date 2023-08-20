import java.util.Scanner;
public class PowerRec {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.println("Enter the number you want to check if it is a palydrome.");
        int base = input.nextInt();

        System.out.println("Enter the number you want to check if it is a palydrome.");
        int power = input.nextInt();

        int result = power(base,power);
        System.out.println(result);
    }
    public static int power(int number,int numberTwo) {
        if(numberTwo>0){
            return power(number, numberTwo - 1) * number ;
        }else {
            return 0 ;
        }
        
    }
}

import java.util.Scanner;
public class EbobEkok {
    public static void main(String[] args) {
        
        // i define veriable 
        int number1 , number2 , ebob= 0 , i = 0 , ekok = 0 ;

        // i create the scanner object
        Scanner input = new Scanner(System.in) ; 

        System.out.print("Enter the first number you want to find the Ebob and Ekok : ");
        number1 = input.nextInt();

        System.out.print("Enter the second number you want to find the Ebob and Ekok : ");
        number2 = input.nextInt();

        while(i <= number1  * number2)
        {
            ++i;
            if(number1 > number2)
            {
                for (int j = 1; j <= number2; j++) {
                    if(number2%i == 0 && number1%i == 0 )
                    {
                        ebob = i ;
                    }
                }
            } else{
                for (int j = 1; j <= number1; j++) {
                    if(number2%i == 0 && number1%i == 0 )
                    {
                        ebob = i ;
                    }
                }
            }
            
        }

        ekok = ((number1*number2)/ebob) ;
        System.out.println("ebob : " + ebob);
        System.out.println("ekok : " + ekok);
    }   
}

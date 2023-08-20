import java.util.Scanner;
public class Calculator {
    public static void main (String[] args)
    {
        // i define variables
        double num1 , num2 , result  ;
        int select ;
        
        // I create the scanner item
        Scanner input = new Scanner(System.in);

        // I get the numbers the user wants to take action on
        System.out.print("Please enter the first number you want to trade.");
        num1 = input.nextDouble() ;

        System.out.print("Please enter the second number you want to trade.");
        num2 = input.nextDouble() ;

        // I get the action the user wants to take
        System.out.print("select the action you want to do 1- addition,2-removal action,3-multiplication,4-division ");
        select = input.nextInt(); 

        // I make my calculations according to the selected transaction type.
      
       {
        switch(select)
        {
            case 1 : 
                result = num1 + num2 ;
                System.out.println("the result of the addition operation : " + result);
                break;
            case 2 : 
                result = num1 - num2 ;
                System.out.println("the result of the removal action  : " + result);
                break;
            case 3 : 
                result = num1 * num2 ;
                System.out.println("the result of the multiplication  : " + result);
                break;
            case 4 : 
                result = num1 / num2 ;
                System.out.println("the result of the division : " + result);
                break;
            default : System.out.println("wrong transaction type");
                break;

        }
       }
    }
}

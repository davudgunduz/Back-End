import java.util.Scanner;
public class arrangement {
    public static void main(String[] args)
    {
        // i define variables 
        int num1 , num2 , num3 ;

        // I create the scanner object
        Scanner input = new Scanner(System.in);

        // I get the variables that the user wants to sort
        System.out.println("enter the first number");
        num1 = input.nextInt();

        System.out.println("enter the second number");
        num2 = input.nextInt();

        System.out.println("enter the thirdt number");
        num3 = input.nextInt();

        // I'm listing the numbers I got from the user

        if(num1 > num2 && num1> num3 ) 
        {
            if(num2 > num3)
            {
                System.out.println(num1 +" > "+ num2 +" > " + num3);
            } else{
                System.out.println(num1 +" > "+ num3 +" > " + num2);
            }
        } else if (num2 > num1 && num2 > num3)
        {
            if(num1 > num3)
            {
                System.out.println(num2 +" > "+ num1 +" > " + num3);
            } else{
                System.out.println(num2 +" > "+ num3 +" > " + num1);
            }
        } else if (num3 > num1 && num3 > num2)
        {
            if(num1 > num2)
            {
                System.out.println(num3 +" > "+ num1 +" > " + num2);
            } else{
                System.out.println(num3 +" > "+ num2 +" > " + num1);
            }
        } 

    }
}

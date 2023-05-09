import java.util.Scanner;
public class bOdyMssIndx {
    public static void main (String[] args)
    {
        // I create the scanner object
        Scanner input = new Scanner(System.in) ; 

         // variable definition
        int weight  ;
        double height, bodyMassIndex ; 

         // I get height and weight information from user
        System.out.print("Enter your height in meters : ");
        height = input.nextDouble();

        System.out.print("Enter your weight in kilograms: ");
        weight = input.nextInt();

        // calculating body mass index
        bodyMassIndex = weight / (height* height) ;

        System.out.println("your body mass index :" + bodyMassIndex);
    }
}

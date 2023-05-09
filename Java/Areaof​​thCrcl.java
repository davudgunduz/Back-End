import java.util.Scanner;
public class Areaof​​thCrcl {
    public static void main (String[] args)
    {
        // I create the scanner object
        Scanner input = new Scanner(System.in) ;

        // i define variables
        double r , angle ;
        final double pi = 3.14 ;

        // I'm getting the race value from the user
        System.out.print("enter the radius of the circle : ");
        r = input.nextDouble();

        // I get the pain value from the user
        System.out.print("enter the angle of the slice  : ");
        angle = input.nextDouble();

        // calculating the area of ​​my slice
        double result = (pi * (r*r) * angle) / 360 ; 
        System.out.println(result);

    }
}

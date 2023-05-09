import java.util.Scanner;
public class AreaCal {
    public static void main (String[] args)
    {
        // variable definition
        int a,b,c,u ;
        
        // I create the scanner object
        Scanner input = new Scanner(System.in) ; 

        // I get the side lengths of the triangle from the user
        System.out.print("enter the side length of the triangle :");
        a = input.nextInt();
        System.out.print("enter the side length of the triangle :");
        b = input.nextInt();
        System.out.print("enter the side length of the triangle :");
        c = input.nextInt();

        // I calculate the value of the variable u
        u = (a+b+c)/2 ;

        // area calculation of triangle
        int squareOfArea = u * (u - a)* (u - b) * (u - c) ;
        double area =  Math.sqrt(squareOfArea) ;

        System.out.println(area);
        
    }
}

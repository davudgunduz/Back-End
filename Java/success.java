import java.util.Scanner;
public class success {
    public static void main(String[] args)
    {
        // i define variables
        int turkish , maths , physics , chemistry , music ;
        double average ;

        // I create the scanner object
        Scanner input = new Scanner(System.in) ;

        // I'm taking notes from the user
        System.out.print("Enter your Turkish course grade : ");
        turkish = input.nextInt();

        System.out.print("Enter your maths course grade : ");
        maths = input.nextInt();

        System.out.print("Enter your physics course grade : ");
        physics = input.nextInt();

        System.out.print("Enter your chemistry course grade : ");
        chemistry = input.nextInt();

        System.out.print("Enter your music course grade : ");
        music = input.nextInt();

        // i calculate the average
        average = (turkish + maths + physics + chemistry +music ) / 5 ;

        // I am checking the status of passing the class
        if(average<=55)
        {
            System.out.println("you failed the class");
        }else{
            System.out.println("you passed the class");
        } 
        System.out.println(average);

    }
}

import java.util.Scanner;
public class user
{
    public static void main(String[] arg)
    {
        // I define variable
        String usarName , password ; 

         // I create the scanner object
        Scanner inputScanner = new Scanner(System.in) ;

        // i get username from user 
        System.out.println("please enter your username");
        usarName = inputScanner.nextLine();

        // I am getting password from user
        System.out.println("please enter your password");
        password = inputScanner.nextLine();

        // I compare the accuracy of the entered information
        if(usarName.equals("Patika") && password.equals("java123"))
        {
            System.out.println("you logged in");
        }else
        {
            System.out.println("wrong informations");
        }
        
    }
}

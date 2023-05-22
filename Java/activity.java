import java.util.Scanner;

public class activity {
    public static void main(String[] args)
    {
        // i define variable
        int heat ;

        // I define the scanner object
        Scanner input = new Scanner(System.in) ;

        // I'm getting the air temperature from the user
        heat = input.nextInt();

        // I recommend activities according to the temperature
        if(heat<=5)
        {
            System.out.println("I suggest you to ski");
        } else if (heat>5 && heat<=15) 
        {
            System.out.println("I recommend you to watch the cinema");
        } else if(heat>15 && heat<=25)
        {
            System.out.println("I suggest you have a picnic");            
        } else 
        {
            System.out.println("I suggest you swim");
        }
    }
}

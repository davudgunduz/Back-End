import java.util.Scanner;
public class taximeter {
    public static void main (String[] args)
    {
        // I have defined the taximeter opening fee and km
        double fee = 10 , km ;

        // I created scanner object
        Scanner input = new Scanner(System.in) ; 

        // I get the distance traveled by the taxi from the user
        System.out.print("Enter the number of kilometers : " );
        km = input.nextDouble(); 

        // account of the fee to be received
        fee += (km * 2.2) ;
        
        // I check the amount of the fee
        if(fee <= 20)
        {
            fee = 20 ;
            System.out.println("the price you will pay : " + fee);
        }else{
            System.out.println("the price you will pay : " + fee);
        }



    }   
}

import java.util.Scanner;
public class ticket {
     public static void main(String[] args) {
        // i define veriables
        int distance , age , tripType ;
        double price ;

        // i create the scanner object 
        Scanner input = new Scanner(System.in);

        // I get age, distance and trip type from user
        System.out.print("Please enter your age : ");
        age = input.nextInt() ;

        System.out.print("please key in the distance to go : ");
        distance = input.nextInt() ;

        System.out.print("please enter your travel type : ");
        System.out.print("one direction=>1 , round-trip => 2 : ");
        tripType = input.nextInt() ;

        price = distance * 0.10 ;
        // I check if the data is useful
        if(age > 0 && distance > 0 && (tripType == 1 || tripType == 0) )
        {
            // ticket account according to the entered data
            if(tripType == 2)
            {
                price = price - (price/5) ;
                if(age<12)
                {
                    price = price - (price/2) ;
                    
                } else if(age > 12 && age < 24){
                    price = price - (price/10) ;
                } else if(age > 65){
                    price = price - (3*price/10) ;
                }
            } else {
                if(age<12)
                {
                    price = price - (price/2) ;
                    
                } else if(age > 12 && age < 24){
                    price = price - (price/10) ;
                } else if(age > 65){
                    price = price - (3*price/10) ;
                }
            }
        }else{
            System.out.println("you entered wrong data"); 
        }

    }
}

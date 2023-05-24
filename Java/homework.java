import java.util.Scanner;
public class homework {
    public static void main(String[] args) {

        // i create the scanner object
        Scanner input = new Scanner(System.in);

        // i define variable
        int number , sum =0 , sum2 = 0  ;

        // I get the number that the user wants to take action
        System.out.print("Please key in the number you want to trade : ");
        number = input.nextInt();

        while(number%2 == 0)
        {
            for(int i =1; i<=number; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
                if(i % 4 == 0)
                {
                    sum += i;
                }
            }
            System.out.println(sum);
            System.out.print("Please key in the number you want to trade : ");
            number = input.nextInt();
        }

    }
}

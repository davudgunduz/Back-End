import java.util.Scanner;
public class MaxMin {
    public static void main(String[] args) {
        // i define variable
        int maxNum , loopNum , minNum , number , temp;
        
        // i create the scanner object
        Scanner input = new Scanner(System.in);

        System.out.print("How many numbers will you enter? : ");
        loopNum = input.nextInt();

        System.out.print("please enter the number : ");
        maxNum = input.nextInt();

        System.out.print("please enter the number : ");
        minNum = input.nextInt();

        if(minNum > maxNum)
            {
                temp = maxNum ;
                maxNum = minNum ;
                minNum = temp ;
            }

        for (int i = 0; i < loopNum - 2; i++) {
            System.out.print("please enter the number : ");
            number = input.nextInt();
    
            if(number > maxNum)
            {
                maxNum = number ; 
            } else if( number < minNum)
            {
                minNum = number ;
            }
        }

        System.out.println("max number : " + maxNum);
        System.out.println("min number : " + minNum);
    }
}

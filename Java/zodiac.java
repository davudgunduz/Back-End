import java.util.Scanner;
public class zodiac {
    public static void main(String[] args)
    {
        // i define veriable
        int year , result ;

        // I define the scanner object
        Scanner input = new Scanner(System.in);

        System.out.println("key in what year you were born");
        year = input.nextInt();
        
        result = year % 12 ;

        switch(result)
        {
            case 0 :
            System.out.print("Cin zodyagi burcunuz : maymun ");
            break;
            case 1 :
            System.out.print("Cin zodyagi burcunuz : horoz ");
            break;
            case 2 :
            System.out.print("Cin zodyagi burcunuz : kopek ");
            break;
            case 3 : 
            System.out.print("Cin zodyagi burcunuz : domuz ");
            break;
            case 4 :
            System.out.print("Cin zodyagi burcunuz : fare ");
            break;
            case 5 : 
            System.out.print("Cin zodyagi burcunuz : okuz ");
            break;
            case 6 :
            System.out.print("Cin zodyagi burcunuz : kaplan ");
            break;
            case 7 :
            System.out.print("Cin zodyagi burcunuz : tavsan ");
            break;
            case 8 :
            System.out.print("Cin zodyagi burcunuz : ejderha ");
            break;
            case 9 : 
            System.out.print("Cin zodyagi burcunuz : yilan ");
            break;
            case 10 :
            System.out.print("Cin zodyagi burcunuz : at ");
            break;
            case 11 : 
            System.out.print("Cin zodyagi burcunuz : koyun ");
            break;
        }
    }
}

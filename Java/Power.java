import java.util.Scanner;
public class Power {
    public static void main(String[] args) {
        int counter = 0 , result = 0 ;
        result = power(counter , result) ;
       System.out.print(result);
    }

    static int power (int counter , int result) {
        
        Scanner input = new Scanner(System.in);
        System.out.println("kuvvetini almak isteiginiz sayiyi tuslayiniz");
        int baseNumber = input.nextInt();

        System.out.println("tabandaki kuvveti tuslayiniz");
        int upNumber = input.nextInt(); 

        counter++;
        if(upNumber != counter) {
            result = baseNumber * baseNumber ;
            
        } 

        return result ;
    }
}

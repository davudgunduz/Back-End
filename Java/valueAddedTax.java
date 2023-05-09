import java.util.Scanner;
public class valueAddedTax {
 public static void main (String[] arg)
 {  
    // i create the scanner object
    Scanner input = new Scanner(System.in);

    // I get price information from user
    System.out.println("please enter the product price");
    double productPrice = input.nextInt() ; 

    // Based on the price of the product, the price with VAT is calculated
    if(productPrice >= 1000)
    {
        productPrice = productPrice + ( productPrice * 0.08) ;
        System.out.print("the price of the product with VAT : "+ productPrice);
    }
    else
    {
        productPrice = productPrice + ( productPrice* 0.18) ;
        System.out.print("the price of the product with VAT : "+ productPrice);
    }
    
 }   
}

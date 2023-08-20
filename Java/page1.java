import java.util.Scanner ;



public class page1 {
    public static void main(String[] args)
    { 
        // this is a comment line
        System.out.println("hello world");
        System.out.println("hi body");
        System.out.println("whatsapp");

        // escape characters 
        System.out.println("escape character 1 \n ");
        System.out.println("escape character 2 \t ");
        System.out.println("escape character 3 \r ");
        System.out.println("escape character 4 \" importent \" ");
        System.out.println("escape character 5 \\ ");

        // veriables and data types
        int numberOne = 7;
        System.out.println(numberOne);

        float numberTwo = 7.777f;
        System.out.println(numberTwo);

        double numberThree = 7.777777777d;
        System.out.println(numberThree);

        char character = 'a' ;
        System.out.println(character);

        boolean status = false ;
        System.out.println(status);

        // Calculate the area and perimeter of a rectangle
        int tallLine = 8 ,shortLine = 6  ;
        int area = (tallLine* shortLine)/2 ;
        int perimeter = (2*shortLine) + (2*tallLine) ;
        System.out.println("the area of the triangle = " + area );
        System.out.println("Perimeter of rectangle = " +perimeter);

        // Other data types
        byte numberFour = 127;
        System.out.println("Maximum value of byte data type = " +numberFour);

        short numberFive = -32768 ;
        System.out.println("Minimum vakue of short data type = " +numberFive);

        long numberSix = 9223372036854775807l;
        System.out.println("Maximum value of long data type = " +numberSix);

        String str = "hi guys welcome to my channel" ;
        System.out.println(str);

        // char data type 
        char characterB = 'B' ;
        char characterb = 98 ;
        System.out.println(characterB);
        System.out.println(characterb);

        // boolean data type
        boolean  situation = true ;
        System.out.println(situation);

        // string data type
        String vName = "Davud Gunduz" ;
        System.out.println(vName);

        // basic operators
        int a = 5 , b = 7 ;

        int sum = a + b ;
        System.out.println(sum);

        int extraction = a - b ;
        System.out.println(extraction);

        int multiply = a * b ; 
        System.out.println(multiply);
        
        float division = a/b ;
        System.out.println(division);

        a = a + b ;  //  a += b ;
        a = a - b ;  //  a -= b ;
        a = a * b ;  //  a *= b ;
        a = a / b ;  //  a /= b ;

        boolean situationAbOne =  a == b ;
        System.out.println(situationAbOne);

        // Scanner 

        

        Scanner input = new Scanner(System.in) ; 

        int k = input.nextInt();
        System.out.println(k);

        String d = input.nextLine() ;
        System.out.println(d);
    }
}

class Pratice {
     public static void main(String[] args) {
        
        System.out.println(sum(2, 5));
        System.out.println(fark(2, 5));
        System.out.println(bolum(2, 5));
        System.out.println(carpim(2, 5));
        System.out.println(fact(5));
        System.out.println(sum(1, 2, 3));
    }  

    static int sum(int numberOne , int numberTwo){
        return numberOne + numberTwo ;
    }
    static int fark(int numberOne , int numberTwo){
        return numberOne - numberTwo ;
    }
    static double bolum(int numberOne , int numberTwo){
        return numberOne / numberTwo ;
    } 
    static int carpim(int numberOne , int numberTwo){
        return numberOne * numberTwo ;
    }
    static int fact(int numberOne ){
        int result = 1 ;
        for (int i = 1; i <= numberOne; i++) {
            result *= i  ; 
        }
        return result ;
    } 
    static int sum(int numberOne , int numberTwo, int numberThree){
        return numberOne + numberTwo + numberThree ;
    }
    

}

    
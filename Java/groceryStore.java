import java.util.Scanner ;
public class groceryStore {
    public static void main (String[] args)
    {
        // degiskenleri tanimliyorum
        double armutKg , elmaKg , domatesKg , muzKg , patlicanKg ;
        double armutFiyat , elmaFiyat , domatesFiyat , muzFiyat , patlicanFiyat ;

        // scanner objesini olusturuyorum
        Scanner input = new Scanner(System.in) ;

        // kullanicidan urun kg bilgisini aliyorum 
        System.out.print("kac kilo armut aldiginizi tuslatiniz : ");
        armutKg = input.nextDouble() ;

        System.out.print("kac kilo elma aldiginizi tuslatiniz : ");
        elmaKg = input.nextDouble() ;

        System.out.print("kac kilo domates aldiginizi tuslatiniz : ");
        domatesKg = input.nextDouble() ;

        System.out.print("kac kilo muz aldiginizi tuslatiniz : ");
        muzKg = input.nextDouble() ;

        System.out.print("kac kilo patlican aldiginizi tuslatiniz : ");
        patlicanKg = input.nextDouble() ;

        // fiyatlari hesapliyorum 
        armutFiyat = armutKg * 2.14d ;
        elmaFiyat = elmaKg * 3.67d ;
        domatesFiyat = domatesKg * 1.11d ;
        muzFiyat = muzKg * 0.95d ; 
        patlicanFiyat = patlicanKg * 5.00d ;
        double result = armutFiyat + elmaFiyat + domatesFiyat+ muzFiyat + patlicanFiyat; 

        System.out.println("Armut kac kilo ? : " + armutKg);
        System.out.println("Elma kac kilo ? : " + elmaKg);
        System.out.println("Domates kac kilo ? : " + domatesKg);
        System.out.println("muz kac kilo ? : " + muzKg);
        System.out.println("patlican kac kilo ? : " + patlicanKg);
        System.out.println("Toplam tutar  : " + result);

    }
}

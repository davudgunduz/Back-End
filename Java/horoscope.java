import java.util.Scanner;
public class horoscope {
    public static void main(String[] args)
    {
        // i define variables
        int day , month ;

        // i create the scanner object
        Scanner input = new Scanner(System.in);

        // I get month and day of birth from user
        System.out.println("the month you were born?");
        month = input.nextInt();

        System.out.println("the day you were born?");
        day = input.nextInt();

        switch(month)
        {
            case 1 : 
                if(day>=1 && day <=31)
                {
                    if(day<22)
                    {
                        System.out.println("oglak burcusunuz");
                    } else{                      
                        System.out.println("kova burcusunuz");
                    }

                } else {
                    System.out.println("you entered an invalid day");
                }
                break;
            case 2 : 
                if(day>=1 && day <=28)
                {
                    if(day<20)
                    {
                        System.out.println("kova burcusunuz");
                    } else{                      
                        System.out.println("balik burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break;   
            case 3 : 
                if(day>=1 && day <=31)
                {
                    if(day<21)
                    {
                        System.out.println("balik burcusunuz");
                    } else{                      
                        System.out.println("koc burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break;
            case 4 : 
                if(day>=1 && day <=30)
                {
                    if(day<21)
                    {
                        System.out.println("koc burcusunuz");
                    } else{                      
                        System.out.println("boga burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break;
            case 5 : 
                if(day>=1 && day <=31)
                {
                    if(day<22)
                    {
                        System.out.println("boga burcusunuz");
                    } else{                      
                        System.out.println("ikizler burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break;  
            case 6 : 
                if(day>=1 && day <=30)
                {
                    if(day<23)
                    {
                        System.out.println("ikizler burcusunuz");
                    } else{                      
                        System.out.println("yengec burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break; 
            case 7 : 
                if(day>=1 && day <=31)
                {
                    if(day<23)
                    {
                        System.out.println("yengec burcusunuz");
                    } else{                      
                        System.out.println("aslan burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break;  
            case 8 : 
                if(day>=1 && day <=31)
                {
                    if(day<23)
                    {
                        System.out.println("aslan burcusunuz");
                    } else{                      
                        System.out.println("basak burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break; 
            case 9 : 
                if(day>=1 && day <=30)
                {
                    if(day<23)
                    {
                        System.out.println("basak burcusunuz");
                    } else{                      
                        System.out.println("terazi burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break; 
            case 10 : 
                if(day>=1 && day <=31)
                {
                    if(day<23)
                    {
                        System.out.println("terazi burcusunuz");
                    } else{                      
                        System.out.println("akrep burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break;
            case 11 : 
                if(day>=1 && day <=30)
                {
                    if(day<22)
                    {
                        System.out.println("akrep burcusunuz");
                    } else{                      
                        System.out.println("yay burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break;
            case 12 : 
                if(day>=1 && day <=31)
                {
                    if(day<22)
                    {
                        System.out.println("yay burcusunuz");
                    } else{                      
                        System.out.println("oglak burcusunuz");
                    }
                    
                } else {
                    System.out.println("you entered an invalid day");
                }
                break;                                                            
        }
    }
}

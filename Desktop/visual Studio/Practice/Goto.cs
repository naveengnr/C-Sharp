public class Goto{

    public void Major(int num){

        ineligible :

        Console.WriteLine("You are Eligible");

        if(num < 18){
            Console.WriteLine("you are not eligible");
                      
                goto ineligible;
        }
    }
}

using System;

namespace CodePractice{

public class MainClass{
    public static void Main(string[] args){

        Fabinocci c = new Fabinocci();

        c.fab(10);

        Goto g = new Goto();
        g.Major(20);


        CalculateSum cs = new CalculateSum();
        Console.WriteLine(cs.Sum(5,10));

        int z = 10;
        Console.WriteLine(z);
        Console.WriteLine(cs.Square(10));
        Console.WriteLine(z);

        int a = 10 ;
        int b = 5 ;
        Console.WriteLine(a + " " + b);
        cs.Swap(ref a , ref b);
        Console.WriteLine(a + " " +  b);

int length =1;
int width =2;
int area;
int perimeter;

Console.WriteLine(length + " " + width);

cs.CalculateRectangle(out length, out width, out area, out perimeter);
Console.WriteLine(length + " " + width);
Console.WriteLine($"Rectangle Perimeter: {perimeter}");
Console.WriteLine($"Rectangle Area: {area}");

     
     Console.WriteLine("max number:" + cs.FindMaximum(1,2,5,4,7,9,86,5));

    }
}
}
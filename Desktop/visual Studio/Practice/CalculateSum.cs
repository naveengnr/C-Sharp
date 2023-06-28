//Write a C# function named "CalculateSum" that takes two integers as parameters and returns their sum. Call this function and display the result.
public class CalculateSum{

public int Sum(int k , int m){

     int add = k + m ;

     return add;
}

// program that demonstrates the concept of call by value. 
// Create a function named "Square" that takes an integer parameter and squares its value inside the function.
// Display the value before and after calling the function.

public int Square(int z){

    z *= z ;

    return z ;
}

// Write a C# program that demonstrates the concept of call by reference. 
// Create a function named "Swap" that takes two integer parameters and swaps their values inside the function.
// Display the values before and after calling the function.

public void Swap(ref int a , ref int b){

    a = a + b ;

    b = a - b ;

    a = a - b ;

}


// Write a C# program that calculates the area and perimeter of a rectangle. 
// Create a function named "CalculateRectangle" that takes the length and width of the rectangle as input parameters.
//  Inside the function, calculate the area and perimeter of the rectangle using the given length and width.
//   The calculated values should be assigned to the corresponding out parameters. Display the area and perimeter of the rectangle in the Main method.

public void CalculateRectangle( out int length , out int width , out int area , out int perimeter){
    
    length = 10 ;
    width = 20 ;

    area = width * length ; 

    perimeter = 2 * (width + length);

}

// Write a C# program that takes an array of integers as input. 
// Create a method named "FindMaximum" that finds and returns the maximum value in the array.
//  In the Main method, prompt the user to enter the size of the array and then the values for each element of the array. 
//  Call the FindMaximum method with the array as an argument and display the maximum value.

public int FindMaximum(params int[] num){
    int max = num[0] ;
    foreach (int i in num){

        if(i > max){

        max = i;

        }
    }
     return max;
}
}
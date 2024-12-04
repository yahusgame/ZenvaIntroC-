internal class Operators
{
    public static void Operator()
    {

        // Operators
        int a = 20;
        int b = 10;

        int c = a + b; // Addition
        c = a - b; // Subtraction
        c = a * b; // Multiplication
        c = a / b; // Division
        Console.WriteLine(c); // a/b = 20/10 = 2

        // Examples of modulo division
        /* 
         29/3 = 9.x
         29%3 = 2
         6%4 = 2
         13%5 = 3
        */

        int num4 = 13;
        int num5 = 5;
        int result = num4 % num5;
        Console.WriteLine(result); // Prints the remainder of 13/5 = 3

        // Increment and decrement operators
        a++; // a = a + 1
        b--; // b = b - 1
        Console.WriteLine("a = " + a);  // a started as 20 and is 21 now
        Console.WriteLine("b = " + b);  // b started as 10 and is 9 now

        // Augmented operators
        a += 15;
        b -= 5;
        Console.WriteLine("a is " + a);  // 21 + 15 = 36
        Console.WriteLine("b is " + b);  // 9 - 5 = 4

        /*
         PEDMAS = 
          Parentheses, 
          Exponents, 
          Multiplication, 
          Division, 
          Addition, and 
          Subtraction
        */

        result = 3 + 4 * 2 - 5;
        Console.WriteLine(result);
        result = 3 + 4 * (2 - 5); // What's inside parentheses is calculated first
        Console.WriteLine(result);

        // Conditional operators:  ==, <, >, <=, >=
        int a1 = 9; // Assigns 9 to a

        if (a1 >= 9)
        { // Checks if a is equal to or greater than 9
            Console.WriteLine("Yes, the value of a is greater than or equal to 9");
        }
        else
        {
            Console.WriteLine("The value of a is less than 9");
        }
    }
}

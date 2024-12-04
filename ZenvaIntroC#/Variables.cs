internal class Variables
{
    public static void Variable()
    {
        /*
          Main Datatypes:
          >integer     -  int     - 32 bits of memory
          >Double      -  double  - 64 bits of memory
          >Boolen      -  bool    - 1 bits ( true or false)
          >Alphanumeric -  string  - variable length
        */

        Console.WriteLine(2 + 4 * 2 - 4); //(atb) * (a-b)

        int g, h; // Variables allow easier changes on the values
        g = 3;
        h = 6;
        Console.WriteLine(g + h* g - h);

        int num1, num2; // Variable Declaration

        num1 = 3; // Variable assignment
        num2 = 6; // Variable assignment


        int num3 = 99; // Combined declaration and assignment

        double d = 99.95; // Storing a decimal value

        bool condition = true; // Storing a boolean value

        string name = "C# Programming"; // Storing a string value - remember to use ""

        Console.WriteLine(num3 + num2);
        Console.WriteLine(d);
        Console.WriteLine(condition);
        Console.WriteLine(name);


        /* Other datatypes */

        float myFloat = 3.14f; // Declare it with suffix f
        Console.WriteLine(myFloat);

        int myInt = 2147483647;  // Maximum value for int
        long myLong = 9223372036854775807L;  // Maximum value for long - use suffix L
        Console.WriteLine(myLong);

        char myChar = 'A'; // Chars are declared with single quotation marks ''
        Console.WriteLine(myChar);

        // Variable Naming Convention 

        double salary = 0000;

    // camelCase
        string firstName = "Azize";
        string lastName = "Dursun";

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(salary);

        //String Interpolation
        Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
        Console.WriteLine($"Hello, {firstName} {lastName}!");

        //Flow of code execution: each line is executed in order until completion

        Console.WriteLine("Please enter your name: ");
        string name1 = Console.ReadLine(); //Receiving user input


        // Once the program receives the name entered, it'll proceed to ask the age
        Console.WriteLine("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());


        // The program will ask for the weight only after receiving the age
        Console.WriteLine("Please enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
    }
}







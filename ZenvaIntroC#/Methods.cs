

class Methods
{
    public static void Method()
    {

        // Calling methods
        string greetings = sendGreeting("Joe");
        Console.WriteLine(greetings);

        printGreeting("Ana");

        printMessage();

        printMessageDynamic(3, "Methods are great!");
        printMessageDynamic(2, "Loops are great!");
        // Method call
        int z = performCalculation(2, 3);
        Console.WriteLine("The value of z is: " + z);
    }

    /*
     Mathematical functions are equivalent to methods
    f(x,y) = 2x+y+3

    f(2,3) = 4+3+3 = 10 
    */

    // Method definition
    static int performCalculation(int x, int y)
    {
        int result = 2 * x + y + 3;
        return result;
    }

    // This method takes a string and returns a greeting message
    static string sendGreeting(string name)
    {
        string greeting = "Hello " + name + "!";
        return greeting;
    }

    // Void methods do not return any results
    static void printGreeting(string name)
    {
        string greeting = "Hello " + name + "!";
        Console.WriteLine(greeting);
    }

    /* Methods so far and their parameters: 
     * int performCalculation(int x, int y)
     * string sendGreeting(string name)
     * void printGreeting(string name)
     */

    // METHODS WITHOUT PARAMETERS
    static void printMessage()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("My life is beautiful");
        }
    }

    static void printMessageDynamic(int number, string message)
    {
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(message);
        }
    }

    
}
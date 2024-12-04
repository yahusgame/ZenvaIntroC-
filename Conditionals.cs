internal class Conditionals
{
    public static void Conditional()
    {

        // CONDITIONAL STATEMENTS: if, else if, and else statements
        int age1 = 70;

        if (age1 < 18)
        {
            Console.WriteLine("You are not eligible");
        }
        else if (age1 < 65)
        {
            Console.WriteLine("You can work!");
        }
        else
        {
            Console.WriteLine("You cannot work here");
        }

        /*
        You are invited to attend Oscars Award
        Evening. 
        1. Do you have invitation ?
        2. Are you a member of Oscar academy ?
        3. Are you a family member of an Oscar member ?
        4. Do you work at food/beverages section ?
        */

        Console.WriteLine("Do you have an invite?");
        string answer1 = Console.ReadLine();

        Console.WriteLine("Are you a member of Oscars academy?");
        string answer2 = Console.ReadLine();

        Console.WriteLine("Are you a family member of an Oscar member?");
        string answer3 = Console.ReadLine();

        Console.WriteLine("Do you work at food and beverages section?");
        string answer4 = Console.ReadLine();

        if (answer1 == "yes" && answer2 == "yes")
        { // AND operator &&
            Console.WriteLine("Welcome!");
        }
        else if (answer3 == "yes" || answer4 == "yes")
        { // OR operator ||
            Console.WriteLine("Welcome!");
        }
        else
        {
            Console.WriteLine("Apologies, you cannot attend!");
        }
        // SWITCH CASE

        Console.WriteLine("Enter two numbers:");
        //double num1 = double.Parse(Console.ReadLine());
        //double num2 = double.Parse(Console.ReadLine());
        double num6 = 20;
        double num7 = 3;
        Console.WriteLine(num6 + " and " + num7);

        Console.WriteLine("Enter operation:\n 1 for addition \n 2 for subtraction \n 3 for multiplication \n 4 for division");
        int operation = int.Parse(Console.ReadLine());

        double result = 0;
        switch (operation)
        {
            case 1: // operation == 1
                result = num6 + num7;
                Console.WriteLine($"The result of addition is: {result}");
                break;
            case 2: // operation == 2
                result = num6 - num7;
                Console.WriteLine($"The result of subtraction is: {result}");
                break;
            case 3: // operation == 3
                result = num6 * num7;
                Console.WriteLine($"The result of multiplication is: {result}");
                break;
            case 4: // operation == 4
                result = num6 / num7;
                Console.WriteLine($"The result of division is: {result}");
                break;
            default: // any other input that is NOT 1, 2, 3, or 4
                Console.WriteLine("Invalid operation input!");
                break;
        }
    }
}
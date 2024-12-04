class Variables
{
    static void /Main()
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
        Console.WriteLine(g + h * g - h);

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
        Console.WriteLine(num1 + " and " + num2);

        Console.WriteLine("Enter operation:\n 1 for addition \n 2 for subtraction \n 3 for multiplication \n 4 for division");
        int operation = int.Parse(Console.ReadLine());

        double result1 = 0;
        switch (operation)
        {
            case 1: // operation == 1
                result = num1 + num2;
                Console.WriteLine($"The result of addition is: {result}");
                break;
            case 2: // operation == 2
                result = num1 - num2;
                Console.WriteLine($"The result of subtraction is: {result}");
                break;
            case 3: // operation == 3
                result = num1 * num2;
                Console.WriteLine($"The result of multiplication is: {result}");
                break;
            case 4: // operation == 4
                result = num1 / num2;
                Console.WriteLine($"The result of division is: {result}");
                break;
            default: // any other input that is NOT 1, 2, 3, or 4
                Console.WriteLine("Invalid operation input!");
                break;

        }

        /*
         * LOOPs
         * FOR LOOP
         * 1. initialization of iteration; i=0
         * 2. termination condition; i<3;
         * 3. execute the body of loop
         * 4. incrementor; i++ => i+1;
       */

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("I love programming");
        }

        /*
        * WHILE LOOP
        * Scenario - Reading book at night
        */

        Console.WriteLine("Are you sleepy?");
        //string answer = Console.ReadLine();
        string answer = "no";
        Console.WriteLine(answer);

        int pagesRead = 0;

        while (answer == "no")
        { // While answer is 'no'
            pagesRead++; // Increments the number of pages already read
            Console.WriteLine("Number of pages read: " + pagesRead);
            Console.WriteLine("Are you sleepy?");
            //answer = Console.ReadLine();
            answer = "yes"; // NOTE: If you hardcode "no" here, the program will run forever
            Console.WriteLine(answer);
        }

        /*
        * DO WHILE
        * Scenario - Handing out pizza slices to friends
        */

        int slicesConsumed = 0;
        string preference;
        do
        { // Serves the first slice without checking for any condition
            slicesConsumed++;
            Console.WriteLine("Num of slices: " + slicesConsumed);
            Console.WriteLine("Would you like one more slice?");
            preference = Console.ReadLine();
            // NOTE: If you hardcode "yes" here, the program will run forever
            Console.WriteLine(preference);
        }
        while (preference == "yes"); // Then it checks if your friend wants more


        /*
          Break - terminates the entire loop
          Continue - skips current iteration only
        */

        // Scenario: You lost your key and there are 15 rooms in the house
        for (int room = 0; room < 15; room++)
        {
            Console.WriteLine("Did you find the key in room " + room);
            //string found = Console.ReadLine();
            string found = "no"; // Note that hardcoding "no" here the key won't be found in any room
            Console.WriteLine(found);

            if (found == "yes")
            {
                Console.WriteLine("Keys found in room" + room);
                Console.WriteLine("Terminating the search");
                break;
            }
        }


        /*
         Gym seven days a week - am I feeling good to go to the gym?
         */
        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine("Can you go to gym today?");
            string answer = Console.ReadLine();
          
            Console.WriteLine(answer);

            if (answer == "no")
            {
                continue;
            }
            Console.WriteLine("Working at the gym: Day " + day);
        }

    }

}






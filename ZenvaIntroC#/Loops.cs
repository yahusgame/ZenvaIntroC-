internal class Loops()
{ 
    public static void Loop()
    {
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

    }
}
    


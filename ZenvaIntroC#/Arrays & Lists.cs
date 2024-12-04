using System.Collections;

public class ArraysLists
{

    public static void Run() // Main Function
    {

        // Storing name of 5 students
        string name1 = "Amy";
        string name2 = "John";
        string name3 = "Anil";
        string name4 = "Ben";
        string name5 = "Eliza";

        // Initializing an array
        string[] names = { "Amy", "John", "Anil", "Ben", "Eliza" };

        // INDEX - position of an element inside an array
        Console.WriteLine(names[3]);
        names[3] = "Benjamin"; // overwrite an array element at given index
        Console.WriteLine(names[3]);

        // We can also create an empty array and then assign values later
        string[] desserts = new string[5];
        desserts[0] = "cookies";
        desserts[1] = "icecream";

        // FOR LOOP with arrays
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        //FOREACH loop
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // 2-dimensional array
        string[,] recipes =
        { 
            // col 0       // col 1       // col 2
            { "cookie",    "pancake",    "muffin" },    // row 0
            { "croissant", "sandwich",   "cake" },      // row 1
            { "fries",     "wonton",     "pasta" }      // row 2
        };

        Console.WriteLine(recipes[0, 2]);
        Console.WriteLine(recipes[2, 2]);

        // 2D arrays with for loop

        // GetLength(0) - number of rows
        // GetLength(1) - number of columns

        for (int row = 0; row < recipes.GetLength(0); row++)
        {
            for (int col = 0; col < recipes.GetLength(1); col++)
            {
                Console.WriteLine("Element at " + row + ", " + col + ": " + recipes[row, col]);
            }
        }

        // ARRAY LIST

        Console.WriteLine("Array Lists:");
        ArrayList nameList = new ArrayList();

        Console.WriteLine(nameList.Count);

        nameList.Add("Beth");
        Console.WriteLine(nameList.Count);

        nameList.Add("Michael");
        Console.WriteLine(nameList.Count);

        nameList.Remove("Beth");
        Console.WriteLine("Count after removing: " + nameList.Count);

        nameList.Add("Amy");
        nameList.Add("Anil");
        nameList.Add("Joseph");

        // Search - IndexOf
        int index = nameList.IndexOf("Amy");
        if (index == -1)
        {
            Console.WriteLine("Element not found");
        }
        else
        {
            Console.WriteLine("Element found at index " + index);
        }
        // Generic Lists - List<T>

        List<int> numbers = new List<int>();
        numbers.Add(5);
        numbers.Add(2);
        numbers.Add(7);
        Console.WriteLine(numbers[0]); // Outputs 5



        // Array lists - store elements of different datatypes

        ArrayList numbersArray = new ArrayList();
        numbersArray.Add(1);
        numbersArray.Add("two");
        numbersArray.Add(3.0);
        Console.WriteLine(numbersArray[1]); // Outputs 1
    }
}
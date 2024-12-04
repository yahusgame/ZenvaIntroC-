using System;
using System.Collections;
internal class Challenges
{
    public static void Challenge()
    {
        variablesChallenge();
        conditionalsChallenge();
        loopsChallenge();
        Refactoring();
        bmiHesaplayici();
        ArrayChallenge();
        ListsChallenge();
        ListsChallenge2();
    }
    static void variablesChallenge()
    {
        /*
         Variables Challenge:
        You're working at an ice cream parlor, 
        and you're responsible for keeping track
        of the inventory of ice cream cones and
        scoops, also collecting cash.
        You need to write a C# program to help
        manage the inventory.
         */

        /* 1. Start with a certain number of ice  cream cones and scoops (you can define these as variables) 
         * 2. Declare a variable for cash at hand which can be initialized to 0.  Use variable names that are logical.
         * 3. Declare variables for price of cone and scoop.
         * 4. Allow the user to order ice cream cones and scoops. Get input from the user for these values. 
         * 5. Deduct the number of cones and scoops ordered from the inventory. Collect cash by incrementing the cash variable.
         * 6. Display the remaining inventory after each order. 
        */

        int adetKulah = 10;
        int adetKepce = 20;

        int fiyatKepce = 2;
        int fiyatKulah = 5;

        int nakit = 0;

        Console.WriteLine("Please Your orderKulah: ");
        int orderKulah = int.Parse(Console.ReadLine());
        Console.WriteLine("Please your orderKepce: ");
        int orderKepce = int.Parse(Console.ReadLine());

        int kalanKulah = adetKulah - orderKulah;
        int kalanKepce = adetKepce - orderKepce;

        Console.WriteLine($" Envanterimizdeki toplam {adetKulah} adet kulah ve  {adetKepce}  adet kepceden {kalanKulah} adet kulah ve  {kalanKepce}   adet kepce kalmıştır.");

        int nakit2 = (orderKulah * fiyatKulah) + (orderKepce * fiyatKepce);
        Console.WriteLine($" Toplam nakitimiz {nakit} TL den {nakit2} TL ye  çıkmıştır.");
    }
    static void conditionalsChallenge()
    {

        /*
         * Scenario: Road Trip Planning
         * You're planning a road trip in your car. Your car has a gas tank capacity of 60 liters and a fuel efficiency of 15 kilometers per liter.  
         * Write a C# program to help you decide if you have enough gas to reach your destination.
         * 1. Start by defining variables for the gas tank capacity, fuel efficiency, and current gas level (which can be initialized to the full tank).
         * 2. Prompt the user to input the number of kilometers they plan to drive.
         * 3. Calculate the maximum distance the car can travel with the current gas level.
         * 4. Check if the input distance is within the range the car can travel.
         * 5. If the distance is within range:
         * If the gas tank level becomes 10 liters or less after the journey, print "Distance successfully traveled, low gas level in tank".
         * If not, print "Distance successfully traveled".
         * 6. If the distance is beyond the range, print "Not enough gas to travel the specified distance". */

        int depoKapasitesi = 60;
        double MevcutGazSeviyesi = 60.0;

        double verim = 15.0;

        Console.WriteLine("Ne kadar yol gitmek istiyorsun?");
        double istenenKm = double.Parse(Console.ReadLine());

        double kalanGazSeviyesi = MevcutGazSeviyesi - (istenenKm / verim);

        double maxKm = depoKapasitesi * verim;
        Console.WriteLine("Tam dolu bir depo ile gidilebilecek toplam mesafe : " + maxKm);

        if (istenenKm <= maxKm)
        {
            if (kalanGazSeviyesi <= 10)
            {
                Console.WriteLine("Kalan gaz seviyesi: " + kalanGazSeviyesi + " litre \nBaşarıyla kat edilen mesafe, depoda düşük benzin seviyesi!");
            }
            else
            {
                Console.WriteLine("Kalan gaz seviyesi: " + kalanGazSeviyesi + " litre \nBaşarı ile kat edilen mesafe!");
            }
        }
        else
        {
            Console.WriteLine("Belirtilen mesafeyi kat etmek için yeterli gaz yok!");
        }
    }
    static void loopsChallenge()
    {
        int hedefAdim = 10000;
        int toplamAdim = 0;
        int kalanAdim;
        int gunlukKalanAdim;
        int saatler = 23;

        for (int i = 0; i <= saatler; i++)
        {
            Console.WriteLine("Bugün kaç adım attınız? ");
            int atilanAdim = int.Parse(Console.ReadLine());

            toplamAdim += atilanAdim;

            if (toplamAdim >= hedefAdim)
            {
                Console.WriteLine("Tebrikler! Toplam" + toplamAdim + " attınız. Günlük hedefinize ulaştınız!" + i);
                break;
            }
            else
            {
                kalanAdim = hedefAdim - toplamAdim;
                Console.WriteLine($"Toplam {toplamAdim} attınız. Hedefinize ulaşmak için {kalanAdim} adım kaldı!" + i);
            }
        }

        if (toplamAdim < hedefAdim)
        {
            Console.WriteLine("Maalesef, Bugünki hedefinizi tamamlayamadınız! Harekete devam!");
            gunlukKalanAdim = hedefAdim - toplamAdim;
            Console.WriteLine("Sadece " + gunlukKalanAdim + " adım kaldı");
        }
    }

    // METHODS
    // Refactor this code!

    // The below code checks if a number is prime

    /* Challenge1*/
    /* * Refactor this! 
     * Refactoring refers to the process of
     * restructuring existing code without
     * changing its external behavior. 
     * It involves making improvements to the
     * code's structure, organization, and
     * readability while keeping its
     * functionality intact.
     */
    static void Refactoring()
    {
        //Methods1Challenge
        int number1 = 17;
        bool isPrime1 = primeNumber(number1);
        Console.WriteLine($"{number1} asaldır: {isPrime1}");

        double number2 = 25;
        double sqrt = squareRootNumber(number2);
        Console.WriteLine($"{number2} ogesinin karekoku {sqrt}");

        int number3 = 5;
        long factorial = factorialNumber(number3);
        Console.WriteLine($"{number3} ogesinin faktoriyeli {factorial}");

        static bool primeNumber(int number1)
        {
            bool isPrime1 = false;
            for (int i = 2; i <= Math.Sqrt(number1); i++)
            {
                if (number1 % i == 0)
                {
                    isPrime1 = false;
                    break;
                }
                isPrime1 = true;
            }
            return isPrime1;
        }
        static double squareRootNumber(double number2)
        {
            // The below code calculates the square root of a number
            double sqrt = Math.Sqrt(number2);
            return sqrt;
        }
        static long factorialNumber(int number3)
        {
            // The below code calculates the factorial of a number
            long factorial = 1;
            for (int i = 2; i <= number3; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

    /*Challenge2*/
    static void bmiHesaplayici()
    {
        Console.WriteLine("BMI Hesaplayiciya hoşgeldiniz!");

        Console.WriteLine("Kilonuuzu kilogram cinsinden yazınız: ");
        double kilo = double.Parse(Console.ReadLine());

        Console.WriteLine("Boyunuzu metre cinsinden giriniz: ");
        double boy = double.Parse(Console.ReadLine());

        Console.WriteLine("Tüketilen toplam kalori miktarını giriniz; ");
        double tuketilenKalori = double.Parse(Console.ReadLine());

        Console.WriteLine("Egzersiz yoluyla yakılan kalori miktarını giriniz: ");
        double yakilanKalori = double.Parse(Console.ReadLine());

        double kiloDeğisim = KiloDegisimHesapla(tuketilenKalori, yakilanKalori);
        double yeniKilo = kilo + kiloDeğisim;
        double bmi = BmiHesapla(yeniKilo, boy);
        string durum = BmiDurumu(bmi);

        Console.WriteLine($"Yeni kilonuz: {yeniKilo:F2} kg");
        Console.WriteLine($"BMI' niz : {bmi:F2}");
        Console.WriteLine($"Kilo durumunuz: {durum}");

        static double BmiHesapla(double kilo, double boy)
        {
            return kilo / (boy * boy);
        }
        static double KiloDegisimHesapla(double tuketilenKalori, double yakilanKalori)
        {
            double kiloArtisi = tuketilenKalori / 5000;
            double kiloKaybi = yakilanKalori / 7000;
            return kiloArtisi - kiloKaybi;
        }
        static string BmiDurumu(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Zayif";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                return "Normal Kilolu";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                return "Kilolu";
            }
            else
            {
                return "Obezite";
            }
        }
    }
    /* Arrays Challenge TAX  CALCULATOR:
    1. Implement a program that asks the user to input their monthly income for each month of the year
    >> Remember to hardcode these values here due to the limitations of the plugin!! 
    2. Store the monthly incomes in an array
    3. Calculate the total income for the year by summing up all the monthly incomes
    4. Determine the tax to be paid
    Let's assume the tax rates are as follows:
    - 0% tax for income up to $20,000
    - 10% tax for income between $20,001 and $50,000
    - 20% tax for income between $50,001 and $100,000
    - 30% tax for income above $100,000
    */
    static void ArrayChallenge()
    {
        decimal[] aylıkGelir = new decimal[12];
        decimal yillikGelir = 0;
        decimal vergi = 0;
        GelirleriAl(ref yillikGelir, aylıkGelir);
        VergiHesapla(ref vergi, yillikGelir);
        Sonuc(yillikGelir, vergi);


        static void GelirleriAl(ref decimal yillikGelir, decimal[] aylıkGelir)
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Lütfen " + (i + 1) + ". aylık gelirinizi giriniz:");
                aylıkGelir[i] = decimal.Parse(Console.ReadLine());
                yillikGelir += aylıkGelir[i];
            }
        }

        static void VergiHesapla(ref decimal vergi, decimal yillikGelir)
        {
            if (yillikGelir <= 20000)
            {
                vergi = yillikGelir * 0;
            }
            else if (yillikGelir >= 50000)
            {
                vergi = yillikGelir * 0.1m;
            }
            else if (yillikGelir <= 100000)
            {
                vergi = yillikGelir * 0.2m;
            }
            else
            {
                vergi = yillikGelir * 0.3m;
            }
        }

        static void Sonuc(decimal yillikGelir, decimal vergi)
        {
            Console.WriteLine("Toplam geliriniz: " + (yillikGelir) + " TL'dir.");
            Console.WriteLine("ödemeniz gereken vergi tutarı: " + vergi);
        }
    }

    /* Lists Challenge  /* Library Book Management System You're developing a simple library book management system 
      * that allows librarians to track the books available in the library.
      * >> Remember to hardcode these values here due to the limitations of the plugin!!
      * Your task is to:
      * 1. Implement a functionality that allows librarians to add books to the library's collection
      * 2. Implement a functionality that allows librarians to remove books from the library's collection
      * 3. Implement a  functionality that allows librarians to check if a book is present in the library
      * 4. Implement a program that displays the current list of books available in the library 
     */
    static void ListsChallenge()
    {
        List<string> books = new List<string>();

        AddBook("Savas ve Baris");
        AddBook("Suc ve Ceza");
        AddBook("Zaman Bisikleti");

        RemoveBook("Savas ve Baris");

        bool varMi = CheckBook("1984");
        Console.WriteLine($" 1984 mevcut mu?  {varMi}");

        DisplayBooks();


        void AddBook(string book)
        {
            books.Add(book);
            Console.WriteLine($"Kitap eklendi: {book}");
        }

        void RemoveBook(string book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine($"Kitap kaldırıldı: {book}");
            }
            else
            {
                Console.WriteLine($"Kitap bulunamadı: {book}");
            }
        }
        bool CheckBook(string book)
        {
            return books.Contains(book);
        }

        void DisplayBooks()
        {
            Console.WriteLine("Kütüphanedeki kitaplar: ");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }

    static void ListsChallenge2()
    {
        List<string> books = new List<string>();

        Console.WriteLine("Welcome to Library");
        Console.WriteLine("1. Add book");
        Console.WriteLine("2. Remove book");
        Console.WriteLine("3. Search for a book");
        Console.WriteLine("4. Display books");
        Console.WriteLine("5. Exit");
        Console.WriteLine("Enter your choice:");

        int choice = 4;
        switch (choice)
        {
            case 1: // Adds a new book to the library
                Console.WriteLine("Enter new book title: ");
                string newBook = Console.ReadLine();
                Console.WriteLine("Adding book: " + newBook);
                books.Add(newBook);
                break;

            case 2: // Removes a book from the library
                Console.WriteLine("Enter book title to be removed: ");
                string bookToRemove = Console.ReadLine();
                Console.WriteLine("Removing book: " + bookToRemove);

                if (books.Remove(bookToRemove))
                {
                    Console.WriteLine("Book removed successfully");
                }
                else
                {
                    Console.WriteLine("Book not found");
                }
                break;

            case 3: // Searchs for a book
                Console.WriteLine("Enter book title you would like to search: ");
                string bookToSearch = Console.ReadLine();
                Console.WriteLine("Searching for: " + bookToSearch);

                if (books.IndexOf(bookToSearch) != -1)
                {
                    Console.WriteLine("Book found!");
                }
                else
                {
                    Console.WriteLine("Book not found!");
                }
                break;

            case 4: // Lists all books in the library
                Console.WriteLine("List of books:");
                foreach (string book in books)
                {
                    Console.WriteLine(book);
                }
                break;

            case 5: // Exits the program
                Console.WriteLine("Exiting program");
                return;

            default: // Prints an error message
                Console.WriteLine("Invalid option!");
                break;
        }

    }
}

    



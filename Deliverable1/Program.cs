using System;

class Program
{
    // Define the initial stock of each item
    static int sodaStock = 100;
    static int chipsStock = 40;
    static int candyStock = 60;

    // Define the minimum stock required for each item
    static int sodaMin = 40;
    static int chipsMin = 20;
    static int candyMin = 40;

    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Restocking Tool.");

        Console.WriteLine("How many sodas have been sold today? 100 are in stock.");
        int sodaPurchased = int.Parse(Console.ReadLine());
        sodaStock -= sodaPurchased;
        Console.WriteLine("There are {0} Sodas left", sodaStock);
        if (sodaStock < sodaMin)
        {
            Console.WriteLine("Soda need to be restocked.");
        }
        else if (sodaStock > 100)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        Console.WriteLine(" ");
        Console.WriteLine("How many chips have been sold today? 40 are in stock.");
        int chipsPurchased = int.Parse(Console.ReadLine());
        chipsStock -= chipsPurchased;
        Console.WriteLine("There are {0} Chips left", chipsStock);
        if (chipsStock < chipsMin)
        {
            Console.WriteLine("Chips need to be restocked.");
        }
        else if (chipsStock > 40)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        Console.WriteLine(" ");
        Console.WriteLine("How many candy have been sold today? 60 are in stock.");
        int candyPurchased = int.Parse(Console.ReadLine());
        candyStock -= candyPurchased;
        Console.WriteLine("There are {0} Candy left", candyStock);
        if (candyStock < candyMin)
        {
            Console.WriteLine("Chips need to be restocked.");
        }
        else if (candyStock > 60)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        Console.WriteLine(" ");

        Console.WriteLine("Soda stock: {0}", sodaStock);
        if (sodaStock < sodaMin)
        {
            Console.WriteLine("Chips need to be restocked.");
        }
        Console.WriteLine("Chips stock: {0}", chipsStock);
        if (chipsStock < chipsMin)
        {
            Console.WriteLine("Chips need to be restocked.");
        }
        Console.WriteLine("Candy stock: {0}", candyStock);
        if (candyStock < candyMin)
        {
            Console.WriteLine("Candy need to be restocked.");
        }
    }
}

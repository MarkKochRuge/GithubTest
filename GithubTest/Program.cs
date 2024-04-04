// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, mig!");


Console.WriteLine("Hello", 25);



class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int arrayLength = 10;
        int[] randomArray = new int[arrayLength];

        Console.WriteLine("Random Array:");

        for (int i = 0; i < arrayLength; i++)
        {
            randomArray[i] = random.Next(1, 101); // Generate random integers between 1 and 100
            Console.WriteLine(randomArray[i]);
        }

        Console.ReadLine();
    }
}
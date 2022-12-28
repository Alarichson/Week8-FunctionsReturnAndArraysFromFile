internal class Program
{
    private static void Main(string[] args)
    {
        string randomFood, randomDrink, randomMovie;
        string[] foods = { "Chicken wings", "pizza", "sushi", "popcorn", "salad" };
        string[] drinks = { "õunamahl", "cola", "fanta", "sprite", "õlu" };
        string[] movies = { "õudukas", "erootika", "komöödia", "draama", "action" };

        randomFood = PickRandomElementFromArray(foods);
        randomDrink = PickRandomElementFromArray(drinks);
        randomMovie = PickRandomElementFromArray(movies);


        Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
        Console.ReadKey();
    }
    private static int GenerateRandomIndex(string[] someArray)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);
        return randomIndex;
    }
    private static string PickRandomElementFromArray(string[] someArray)
    {
        string randomElement = someArray[GenerateRandomIndex(someArray)];
        return randomElement;

    }
}
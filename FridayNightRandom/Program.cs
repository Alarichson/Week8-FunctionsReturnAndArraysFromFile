internal class Program
{
    private static void Main(string[] args)
    {
        DisplayRandomFood();
        DisplayRandomDrink();
        DisplayRandomMovie();
    }
    private static int GenerateRandomIndex(string[] someArray)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);

        return randomIndex;
    }
    private static void DisplayRandomFood()
    {
        string[] foods = { "Chicken wings", "pizza", "sushi", "popcorn", "salad" };

        Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");

    }
    private static void DisplayRandomDrink()
    {
        string[] drinks = { "õunamahl", "cola", "fanta", "sprite", "õlu" };

        Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");

    }
    private static void DisplayRandomMovie()
    {
        string[] movies = { "õudukas", "erootika", "komöödia", "draama", "action" };

        Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");

    }
}
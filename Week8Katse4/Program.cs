internal class Program
{
    private static void Main(string[] args)
    {
        DisplayRandomFood();
        DisplayRandomDrink();
        DisplayRandomMovie();
        Console.ReadKey();
    }

    private static void DisplayRandomFood()
    {
        string[] foods = { "Chicken wings", "pizza", "sushi", "popcorn", "salad" };
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, foods.Length);

        string randomFood = foods[randomIndex];
        Console.WriteLine($"Computer picked: {randomFood}");

    }
    private static void DisplayRandomDrink()
    {
        string[] drinks = { "õunamahl", "cola", "fanta", "sprite", "õlu" };
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, drinks.Length);

        string randomDrink = drinks[randomIndex];
        Console.WriteLine($"Computer picked: {randomDrink}");

    }
    private static void DisplayRandomMovie()
    {
        string[] movies = { "õudukas", "erootika", "komöödia", "draama", "action" };
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, movies.Length);

        string randomMovies = movies[randomIndex];
        Console.WriteLine($"Computer picked: {randomMovies}");

    }
}
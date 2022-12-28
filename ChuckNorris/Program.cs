internal class Program
{
    private static void Main(string[] args)
    {
        string randomJoke;
        randomJoke = GetRandomFromFile("chuck.txt");
        
        Console.WriteLine($"Todays joke is {randomJoke}");



    }
    private static int GenerateRandomIndex(string[] someArray)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);
        return randomIndex;
    }

    private static string GetRandomFromFile(string fileName)
    {
        string filePath = $@"D:\\OneDrive\\TKTK\\Programmeerimise algkursus (RKE132) -\\Samples\{fileName}";
        string[] dataFromFile = File.ReadAllLines(filePath);
        string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

        return randomElement;
    }
}